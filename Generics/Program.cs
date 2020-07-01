using Generics.Entities;
using Generics.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService();
            CalculationService();

            Console.ReadLine();
        }

        private static void CalculationService()
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter values:");
            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');

                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();
            Product p = calculationService.Max(list);
            //Product p = list.Max();

            Console.WriteLine("\nMost expensive:");
            Console.WriteLine(p);
        }

        private static void PrintService()
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter values:");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
