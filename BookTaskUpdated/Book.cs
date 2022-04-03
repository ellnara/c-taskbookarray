using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Book:Product
    {
        public string Genre;
        public Book()
        {

        }
        public Book(string name, double price, string genre) :base(name, price)
        {
            if (Genre == "" || Genre == " ")
            {
                Console.WriteLine("Enter the correct Genre");
            }
            else
            {
                Genre = genre;
            }
        }
    }
}
