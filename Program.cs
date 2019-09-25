using System;
using System.Collections.Generic;
namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new List<double>();
            double x1, x2;
            bool flag = false;
            do {
                Console.WriteLine("Введите коэффициенты");
                for (int i = 0; i < 3; i++)
                {
                    if (Double.TryParse(Console.ReadLine(), out double result))
                    {
                        values.Add(result);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверный формат данных");
                        i--;
                    }
                }
                double a = values[0];
                double b = values[1];
                double c = values[2];
                values.Clear();

                if (a == 0 && b == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Действительных корней нет");
                }

                else if ((a != 0 || b != 0) & c == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Уравнение имеет один корень: 0");
                }

                else if (a == 0 || b == 0)
                {
                    x1 = -c / b;
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (x1 > 0)
                    {
                        if (a == 0 && b != 0)
                        {
                            Console.WriteLine($"Уравнение имеет два корня: {Math.Pow(x1, 0.25)} , {-(Math.Pow(x1, 0.25))}");
                        }
                        else
                        {
                            Console.WriteLine($"Уравнение имеет два корня: {Math.Sqrt(x1)} , {-(Math.Sqrt(x1))}");
                        }
                    }
                    else if (x1 == 0)
                    {
                        Console.WriteLine("Уравнение имеет один корень: 0");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Действительных корней нет");
                    }
                }

                else if (a != 0 && b != 0 && c == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    x1 = -b / a;
                    if (x1 == 0)
                    {
                        Console.WriteLine("Уравнение имеет один корень: 0");
                    }
                    else if (x1 > 0)
                    {
                        Console.WriteLine($"Уравнение имеет три корня: {Math.Sqrt(x1)} , {-(Math.Sqrt(x1))} , 0");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Действительных корней нет");
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
                            Console.WriteLine($"Уравнение имеет два корня: {x1} , {-x1}");
                        }
                    }

                    else if (d > 0)
                    {
                        x1 = (-b + Math.Sqrt(d)) / 2 * a;
                        x2 = (-b - Math.Sqrt(d)) / 2 * a;
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
                if (choice.ToLower().Equals("да"))
                    flag = true;
                else
                    flag = false;
            } while (flag);
        }
    }
}