using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new Rectangle(5, 6);
            var q1 = new Quadrate(10);
            var c1 = new Circle(15);

            Console.WriteLine("Исходные данные коллекции ArrayList:\n");
            Console.WriteLine(new string('-', 30));
            var al = new ArrayList() {r1,c1,q1};
            foreach (object o in al) Console.WriteLine(o);
            al.Sort();

            Console.WriteLine("\nОтсортированные данные коллекции ArrayList:\n");
            Console.WriteLine(new string('-', 30));
            foreach (object o in al) Console.WriteLine(o);

            Console.WriteLine("\nИсходные данные коллекции List:\n");
            Console.WriteLine(new string('-', 30));
            var list = new List<Geometric_figure>() {r1,c1,q1};
            foreach (object o in list) Console.WriteLine(o);
            list.Sort();

            Console.WriteLine("\nОтсортированные данные коллекции List:\n");
            Console.WriteLine(new string('-', 30));
            foreach (object o in list) Console.WriteLine(o.ToString());

            Console.WriteLine("\nМатрица");
            Console.WriteLine(new string('-', 30));
            var matrix = new Matrix<Geometric_figure>(3, 3, 3, new FigureMatrixCheckEmpty());
            matrix[1, 0, 0] = r1;
            matrix[0, 1, 0] = q1;
            matrix[0, 0, 1] = c1;
            Console.WriteLine(matrix.ToString());

            Console.WriteLine("\nСтек");
            Console.WriteLine(new string('-', 30));
            var stack = new SimpleStack<Geometric_figure>();
            stack.Add(c1);
            stack.Add(r1);
            stack.Add(q1);
            stack.Push(r1);
            stack.Push(q1);
            stack.Push(c1);

            while (stack.Count > 0)
            {
                Geometric_figure f = stack.Pop();
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }
    }
}
