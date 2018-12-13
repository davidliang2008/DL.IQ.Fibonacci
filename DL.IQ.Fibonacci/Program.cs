using System;
using System.Collections.Generic;
using System.Linq;

namespace DL.IQ.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many Fibonacci numbers you want to display:");
            int count = Int32.Parse(Console.ReadLine());

            var series = GetFibonacciSeries(count);

            Print(series);

            Console.ReadKey();
        }

        static IEnumerable<int> GetFibonacciSeries(int count)
        {
            IList<int> series = new List<int> { 0 };

            if (count > 1)
            {
                series.Add(1);
            }

            for (int i = 3; i <= count; i++)
            {
                series.Add(series[i - 2] + series[i - 3]);
            }

            return series;
        }

        static void Print(IEnumerable<int> series)
        {
            Console.WriteLine();
            Console.WriteLine("The Fibonacci Series you requested: ");

            foreach (int num in series)
            {
                Console.Write($"{ num } ");
            }

            Console.WriteLine();

        }
    }
}
