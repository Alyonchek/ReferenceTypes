using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(0, 0, 2, 2);
            Console.WriteLine(line.Draw());

            Circle circle = new Circle(1, 1, 5);
            Console.WriteLine(circle.Draw());

            Round round = new Round(1, 1, 5, "Красный") ;
            Console.WriteLine(round.Draw());

            Rectangle rectange = new Rectangle(12,10,34,15,34,12);
            Console.WriteLine(rectange.Draw());

            Ring ring = new Ring(5, 5, 5, "Красный",2,2,2,"Белый");
            Console.WriteLine(ring.Draw());

        }
    }
}
