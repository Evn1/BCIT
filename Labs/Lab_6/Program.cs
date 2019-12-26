using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        delegate int MultOrPlus(int p1, int p2);
        static int Multiply(int p1, int p2) { return p1 * p2; }
        static int Plus(int p1, int p2) { return p1 + p2; }
        static void MultOrPlusMethod(string str, int i1, int i2, MultOrPlus MultOrPlusProgram)
        {
            int result = MultOrPlusProgram(i1, i2);
            Console.WriteLine(str + result.ToString());
        }
        static void MultOrPlusMethodFunc(string str, int i1, int i2, Func<int, int, int> MultOrPlusProgram)
        {
            int result = MultOrPlusProgram(i1, i2);
            Console.WriteLine(str + result.ToString());
        }
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №6\n";
            string str1;
            string str2;
            Console.Write("Введите первый аргумент: ");
            str1 = Console.ReadLine();
            Console.Write("Введите второй аргумент: ");
            str2 = Console.ReadLine();
            int i1 = int.Parse(str1);
            int i2 = int.Parse(str2);

            MultOrPlusMethod("\nУмножаем: ", i1, i2, Multiply);
            MultOrPlusMethod("Складываем: ", i1, i2, Plus);

            // Экземпляры делегатов
            MultOrPlus p1 = new MultOrPlus(Multiply);
            MultOrPlus p2 = new MultOrPlus(Plus);

            MultOrPlusMethod("\nУмножение, использую экземпляр делегата: ", i1, i2, Multiply);
            MultOrPlusMethod("Сложение, использую экземпляр делегата:", i1, i2, Plus);

            MultOrPlusMethod("Создание экземпляра делегата на основе лямбда-выражения: ", i1, i2, (x, y) => x * y);

            Console.WriteLine("\n\nИспользование обощенного делегата Func< >");

            MultOrPlusMethodFunc("Создание экземпляра делегата на основе метода: ", i1, i2, Multiply);
            MultOrPlusMethodFunc("Создание экземпляра делегата на основе лямбда-выражения: ", i1, i2, (x, y) => x * y);

            Console.ReadKey();
        }
    }
}
