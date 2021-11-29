using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    class Rectangle : Line
    {
        private int _w;
        private int _h;
        public Rectangle(int x, int y, int endX, int endY,int width, int height) : base(x, y, endX, endY)
        {
            Height = height;
            Width = width;           
        }

        public int Width { 
            get { return _w; }
            set {
                _w = EndX - X;
            }
        }
        public int Height
        {
            get { return _h; }
            set
            {
                _h = EndY - Y;
            }
        }


        public override string Draw()
        {
            return string.Format("Фигура прямоугольник:  \nширина: {0}; \n высота: {1};",Width,Height);
        }
    }
}
