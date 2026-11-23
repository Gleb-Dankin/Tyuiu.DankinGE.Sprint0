using System;
using Tyuiu.DankinGE.Sprint0.Task3.V0.Lib;

namespace Tyuiu.DankinGE.Sprint0.Task3.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 7;
            int result = DataService.Sum(a, b);
            Console.WriteLine($"{a} + {b} = {result}");
            Console.ReadKey();
        }
    }
}