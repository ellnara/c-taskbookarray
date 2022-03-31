using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Product
    {

        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public Book[] books = { };
        public Product()
        {

        }
        public Product(int no, string name, int count, double price)
        {
            if (name == "" || name == " " || price == 0 || no == 0)
            {
                Console.WriteLine("cannot create product");
            }
            else
            {
                Name = name;
                No = no;
                Count = count;
                Price = price;
            }
        }


    }
}
