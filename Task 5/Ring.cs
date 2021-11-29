using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    class Ring:Round
    {
        private int _rad;
        public Ring(int x, int y, int radius, string color,int a,int b, int rad,string col) : base(x, y, radius,color)
        {
            A = a;
            B = b;
            Rad = rad;
            Col = col;
        }
        public int Rad
        {
            get { return _rad; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _rad = value;
            }
        }
        public string Col { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        

        public override string Draw()
        {
            return string.Format("Фигура кольцо:\n начальная точка большего круга: X:{0},Y:{1}; \n радиус большего круга: {2}, \n цвет большего круга: {3},\n начальная точка малого круга: X:{4},Y:{5}; \n радиус малого круга: {6}, \n цвет малого круга: {7}", X, Y, Radius, Color,A,B,Rad,Col);
        }
    }
}
