using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Book:Product
    {
        public string Genre { get; set; }
        public Book()
        {

        }
        public Book(int no, string name, int count, double price, string genre):base(no,name,count,price)
        {
            if (genre==""|| genre==" ")
            {
                Console.WriteLine("Cannot create book");
            }
            else
            {
                Genre = genre;
            }
        }
        public void ShowInfo()
        {
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"No: {No}  Name: {Name}  Count: {Count}  Price: {Price}");
        }
        public void GetAllInfo()
        {
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
        }
    }
}
