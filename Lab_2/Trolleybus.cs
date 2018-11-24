using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Trolleybus : Bus
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия аккамулятора
        /// </summary>
        public bool Accumulator { private set; get; }
        ///
        /// Признак наличия рожек
        ///
        public bool Horns { private set; get; }
        ///
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// /// <param name="accumulator">Признак наличия аккамулятора</param>
        /// <param name="horns">Признак наличия рожек</param>
        public Trolleybus(int maxSpeed, float weight, Color mainColor, Color dopColor, bool accumulator, bool horns) :
 base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Accumulator = accumulator;
            Horns = horns;
        }
        public Trolleybus(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Accumulator = Convert.ToBoolean(strs[4]);
                Horns = Convert.ToBoolean(strs[5]);
            }
        }
        public override void DrawBus(Graphics g)
        {
            base.DrawBus(g);
            Pen pen = new Pen(DopColor);
            Brush brush = new SolidBrush(DopColor);
            if (Horns)
            {
                g.DrawLine(pen, _startPosX + 50, _startPosY, _startPosX + 35, _startPosY - 30);
                g.DrawLine(pen, _startPosX + 40, _startPosY, _startPosX + 25, _startPosY - 30);
            }
            if (Accumulator)
            {
                g.FillRectangle(brush, _startPosX - 5, _startPosY + 10, 5, 25);
            }
        }
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Accumulator + ";" +
           Horns;
        }
    }
}

