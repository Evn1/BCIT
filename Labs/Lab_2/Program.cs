using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new Rectangle(5, 6);
            var q1 = new Quadrate(10);
            var c1 = new Circle(15);
            r1.Print();
            q1.Print();
            c1.Print();
            Console.ReadKey();
        }
    }
}
