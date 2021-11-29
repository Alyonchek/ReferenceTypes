using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    class Round : Circle
    {
        public Round(int x, int y, int radius, string color):base(x,y,radius)
        {
            Color = color;
        }

        public string Color { get; set; }

        public override string Draw()
        {
            return string.Format("Фигура круг:\n начальная точка: X:{0},Y:{1}; \n радиус: {2}, \n цвет: {3}", X, Y, Radius,Color);
        }
    }
}
