using System;
using Tyuiu.DankinGE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DankinGE.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Глеб";
            Console.WriteLine(DataService.GetMessage(name));
            Console.ReadKey();
        }
    }
}