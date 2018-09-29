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
                g.FillRectangle(brush, _startPosX - 10, _startPosY + 10, 10, 25);
            }
        }
    }
}

