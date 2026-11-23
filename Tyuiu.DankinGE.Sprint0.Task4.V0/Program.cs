using System;
using Tyuiu.DankinGE.Sprint0.Task4.V0.Lib;

namespace Tyuiu.DankinGE.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сложение: 1 + 5 = " + DataService.Addition(1, 5));
            Console.WriteLine("Вычитание: 10 - 5 = " + DataService.Subtraction(10, 5));
            Console.WriteLine("Умножение: 4 * 4 = " + DataService.Multiplication(4, 4));
            Console.WriteLine("Деление: 10 / 2 = " + DataService.Division(10, 2));
            Console.ReadKey();
        }
    }
}
