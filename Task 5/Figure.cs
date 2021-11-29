using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    public abstract class Figure
    {
        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public abstract string Draw();
    }
}
