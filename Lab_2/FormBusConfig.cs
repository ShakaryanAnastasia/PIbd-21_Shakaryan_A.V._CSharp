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
    public partial class FormBusConfig : Form
    {
        ITransport bus = null;

        /// <summary>
        /// Событие
        /// </summary>
        private event busDelegate eventAddTransport;
        public FormBusConfig()
        {
            InitializeComponent();
            panelBlueViolet.MouseDown += panelColor_MouseDown;
            panelTurquoise.MouseDown += panelColor_MouseDown;
            panelAquamarine.MouseDown += panelColor_MouseDown;
            panelActiveBorder.MouseDown += panelColor_MouseDown;
            panelMediumVioletRed.MouseDown += panelColor_MouseDown;
            panelDarkViolet.MouseDown += panelColor_MouseDown;
            panelLightBlue.MouseDown += panelColor_MouseDown;
            panelLightCoral.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать автобус
        /// </summary>
        private void DrawBus()
        {
            if (bus != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTransport.Width, pictureBoxTransport.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bus.SetPosition(15, 35, pictureBoxTransport.Width, pictureBoxTransport.Height);
                bus.DrawBus(gr);
                pictureBoxTransport.Image = bmp;
            }
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(busDelegate ev)
        {
            if (eventAddTransport == null)
            {
                eventAddTransport = new busDelegate(ev);
            }
            else
            {
                eventAddTransport += ev;
            }
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBus_MouseDown(object sender, MouseEventArgs e)
        {
            labelBus.DoDragDrop(labelBus.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelTrolleybus_MouseDown(object sender, MouseEventArgs e)
        {
            labelTroll.DoDragDrop(labelTroll.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTransport_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTransport_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Автобус":
                    bus = new Bus(100, 500, Color.White);
                    break;
                case "Троллейбус":
                    bus = new Trolleybus(100, 500, Color.White, Color.Black, true, true);
                    break;
            }
            DrawBus();
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                bus.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawBus();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                if (bus is Trolleybus)
                {
                    (bus as Trolleybus).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawBus();
                }
            }
        }
        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddTransport?.Invoke(bus);
            Close();
        }
    }
}
