using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    public class Line : Figure
    {
        public Line(int x, int y,int endX, int endY) : base(x,y)
        {
            EndX = endX;
            EndY = endY;
        }

        public int EndX { get; set; }
        public int EndY { get; set; }
        public override string Draw()
        {
            return string.Format("Фигура линия: \nначальная точка: X:{0},Y:{1};\n  конечная точка: X:{2},Y:{3}", X, Y, EndX, EndY);

        }
    }
}
