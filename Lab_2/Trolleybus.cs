using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Trolleybus : Bus, IComparable<Trolleybus>, IEquatable<Trolleybus>
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
        /// <summary>
        /// Метод интерфейса IComparable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Trolleybus other)
        {
            var res = (this is Bus).CompareTo(other is Bus);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Accumulator != other.Accumulator)
            {
                return Accumulator.CompareTo(other.Accumulator);
            }
            if (Horns != other.Horns)
            {
                return Horns.CompareTo(other.Horns);
            }

            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Trolleybus other)
        {
            var res = (this as Bus).Equals(other as Bus);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Accumulator != other.Accumulator)
            {
                return false;
            }
            if (Horns != other.Horns)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Trolleybus carObj = obj as Trolleybus;
            if (carObj == null)
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

