using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var z = new Zadanie4();
            int[] numbers = { 10, 20, 30, 40 };
            int index = z.IndexOf(numbers, 30);

            Console.WriteLine(index >= 0? $"Indeks elementu: {index}" : "Element nie istnieje.");
            Console.ReadKey();
        }
    }
}
