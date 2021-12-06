using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
          List<Figure> FigureList= new List<Figure>(); 
            
            FigureList.Add(new Line(0, 0, 2, 2));

            FigureList.Add(new Circle(1, 1, 5));

            FigureList.Add(new Round(1, 1, 5, "Красный"));
            FigureList.Add( new Rectangle(12, 10, 34, 15, 34, 12));

            FigureList.Add(new Ring(5, 5, 5, "Красный", 2, 2, 2, "Белый"));

            foreach (Figure Ring in FigureList)
                Console.WriteLine(Ring.Draw());

        }
    }
}
