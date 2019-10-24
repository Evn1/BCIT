using System;
namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, a, b, c;
            do
            {
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

                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    double d = b * b - 4 * a * c;
                    if (d < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Действительных корней нет");
                    }
                    if (d == 0)
                    {
                        x1 = -b / (2 * a);
                        if (x1 < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Действительных корней нет");
                        }
                        else
                        {
                            x1 = Math.Sqrt(x1);
                            Console.WriteLine($"Уравнение имеет два корня: {x1} , {x1}");
                        }
                    }

                    else if (d > 0)
                    {
                        x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - Math.Sqrt(d)) / (2 * a);
                        if ((x1 < 0) & (x2 < 0))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Действительных корней нет");
                        }
                        else if ((x1 < 0) || (x2 < 0))
                        {
                            if (x1 < 0)
                            {
                                x2 = Math.Sqrt(x2);
                                Console.WriteLine($"Уравнение имеет два корня: {x2} , {-x2}");
                            }
                            else
                            {
                                x1 = Math.Sqrt(x1);
                                Console.WriteLine($"Уравнение имеет два корня: {x1} , {-x1}");
                            }
                        }
                        else
                        {
                            x1 = Math.Sqrt(x1);
                            x2 = Math.Sqrt(x2);
                            Console.WriteLine($"Уравнение имеет четыре корня: {x1} ,  {-x1} , {x2} , {-x2}");
                        }
                    }
                }
                Console.ResetColor();
                Console.WriteLine("Продолжить решение уравнений ? (Да/Нет)");
                string choice = Console.ReadLine();
                if (!(choice.ToLower().Equals("да")))
                    break;
            } while (true);
        }
    }
}

