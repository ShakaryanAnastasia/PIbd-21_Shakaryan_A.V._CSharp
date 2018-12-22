using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса многоуровневой парковки
        /// </summary>
        MultiLevelParking parking;
        /// <summary>
        /// Форма для добавления
        /// </summary>
        FormBusConfig form;
        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;
        /// <summary>
        /// Логгер
        /// </summary>
        private Logger logger;        public FormParking()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
           pictureBoxParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevel.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevel.SelectedIndex = 0;
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxLevel.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт
             //  не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу
             //   listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
               pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevel.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlace_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex > -1)
            {
                if (maskedTextBoxPlace.Text != "")
                {
                    try
                    {
                        var bus = parking[listBoxLevel.SelectedIndex] -
                       Convert.ToInt32(maskedTextBoxPlace.Text);
                        Bitmap bmp = new Bitmap(pictureBoxPlace.Width,
                       pictureBoxPlace.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        bus.SetPosition(10, 20, pictureBoxPlace.Width,
                       pictureBoxPlace.Height);
                        bus.DrawBus(gr);
                        pictureBoxPlace.Image = bmp;
                        logger.Info("Изъят автомобиль " + bus.ToString() + " с места " + maskedTextBoxPlace.Text);

                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxPlace.Width,
                       pictureBoxPlace.Height);
                        pictureBoxPlace.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetBus_Click(object sender, EventArgs e)
        {
            form = new FormBusConfig();
            form.AddEvent(AddTransport);
            form.Show();
        }
        /// <summary>
        /// Метод добавления машины
        /// </summary>
        /// <param name="car"></param>
        private void AddTransport(ITransport bus)
        {
            if (bus != null && listBoxLevel.SelectedIndex > -1)
            {
                try
                {
                    int place = parking[listBoxLevel.SelectedIndex] + bus;
                    logger.Info("Добавлен автомобиль " + bus.ToString() + " на место " +
     place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Сортировка"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSort_Click(object sender, EventArgs e)
        {
            parking.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}


