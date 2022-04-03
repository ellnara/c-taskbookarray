
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Product
    {
        public int no { get; set; }
        private static int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product()
        {
            No++;
            no = No;
        }
        public Product(string name, double price):this()
        {
            if (Price < 0)
            {
                Console.WriteLine("Enter a valid price");
            }
            else
            {
                Price=price;
            }
            if (Name == "" || Name == " ")
            {
                Console.WriteLine("Enter a valid name");
            }
            else
            {
                Name=name;
            }
        }
    }
}
