using System;
using System.Collections.Generic;
using inheritance5_CSharp.entities;
using System.Globalization;

namespace inheritance5_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (ch == 'c')
                {
                    Product p = new Product(name, price);
                    list.Add(p);
                }
                if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    UsedProduct used = new UsedProduct(date, name, price);
                    list.Add(used);
                }

                if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    ImportedProduct imported = new ImportedProduct(customsFee, name, price);
                    list.Add(imported);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Price tags:");
            foreach (Product item in list)
            {
                Console.WriteLine(item.PriceTag().ToString());
            }
        }
    }
}
