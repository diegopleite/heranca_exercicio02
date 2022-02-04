using Heranca_exercicio02.Entities;
using System;
using System.Collections.Generic;

namespace Heranca_exercicio02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product {i} data: ");
                Console.Write("Common, used or imported (C/U/I): ");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (productType == 'I' || productType == 'i') {
                    Console.Write("Custom Fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    Product prod = new ImportedProduct(name, price, customFee);
                    list.Add(prod);
                }
                else if (productType == 'U' || productType == 'u') {
                    Console.Write("Manufacture Date: ");
                    DateTime mDate = DateTime.Parse(Console.ReadLine());
                    Product prod = new UsedProduct(name, price, mDate);
                    list.Add(prod);
                }

                else {
                    Product prod = new Product(name, price);
                    list.Add(prod);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Price Tags: ");
            foreach (Product prod in list) {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
