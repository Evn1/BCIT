using System;
namespace Lab
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
