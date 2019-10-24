using System;
namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, a, b, c;
            while (true)
            {
                Console.WriteLine("Введите коэффициенты: ");
                if (Double.TryParse(Console.ReadLine(), out a) & Double.TryParse(Console.ReadLine(), out b) & Double.TryParse(Console.ReadLine(), out c))
                    break;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных\n");
                    Console.ResetColor();
                }
            }
            if (a == 0 || b == 0 || c == 0)
            {
                if ((a == 0 && b == 0) || (-c / b < 0) || (-c / a < 0))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Действительных корней нет");
                }
                else if (((a == 0 || b == 0) && c == 0) || ((a != 0) && (-b / a < 0)))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Уравнение имеет один корень: 0");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    if ((a != 0) && (-c / a > 0))
                    {
                        Console.WriteLine($"Уравнение имеет два корня: {Math.Pow((-c / a), 0.25)} , {-(Math.Pow((-c / a), 0.25))}");
                    }
                    if ((b != 0) && (-c / b > 0))
                    {
                        Console.WriteLine($"Уравнение имеет два корня: {Math.Sqrt((-c / b))} , {-(Math.Sqrt(-c / b))}");
                    }
                    if ((a != 0) && (-b / a > 0))
                    {
                        Console.WriteLine($"Уравнение имеет три корня: 0 , {Math.Sqrt((-b / a))} , {-(Math.Sqrt(-b / a))}");
                    }
                }
            }
        }
    }
}
