using System;
using Tyuiu.DankinGE.Sprint0.Task5.V0.Lib;

namespace Tyuiu.DankinGE.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сложение: 1 + 5 = " + DataService.Addition(1, 5));
            Console.WriteLine("Вычитание: 10 - 5 = " + DataService.Subtraction(10, 5));
            Console.WriteLine("Умножение: 4 * 4 = " + DataService.Multiplication(4, 4));
            Console.WriteLine("--- Пытаемся делить на 0 ---");
            int a = 10;
            int b = 0;
            int result = DataService.Division(a, b);
            if (result == -1)
            {
                Console.WriteLine($"Переменная b = {b}, на 0 делить нельзя. Ошибка {result}");
            }
            else
            {
                Console.WriteLine($"Деление: {a} / {b} = {result}");
            }
            Console.WriteLine("--- Нормальное деление ---");
            b = 2;
            result = DataService.Division(a, b);
            Console.WriteLine($"Деление: {a} / {b} = {result}");

            Console.ReadKey();
        }
    }
}
