using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the book count: ");
            int count = int.Parse(Console.ReadLine());
            Book[] books = new Book[count];
            Book[] sortedBooks = new Book[count];


            Book bookss= new Book();

            for (int i = 0; i < books.Length; i++)
            {

                Book book = new Book();
                Console.WriteLine("Enter book number");
                book.No = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter book name");
                book.Name = Console.ReadLine();
                Console.WriteLine("Enter book price");
                book.Price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter book genre");
                book.Genre = Console.ReadLine();
                books[i] = book;
                book.ShowInfo();
            }
           
         Console.WriteLine($"Menu: \n1.Kitablari qiymete gore filterle \n2.Butun kitablari goster \n0.Proqrami bagla");
            int input = int.Parse(Console.ReadLine());
            if (input==1)
            {
                Console.WriteLine("Enter min price: ");
                int minPrice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter max price: ");
                int maxPrice = int.Parse(Console.ReadLine());
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i].Price>books[i+1].Price)
                    {
                         sortedBooks[i] = books[i];
                    }
                }
                foreach (var item in sortedBooks)
                {
                    Console.WriteLine(item);
                }
            }
            else if(input==2)
            {
                foreach (var item in books)
                {
                    Console.WriteLine(item);
                }
            }
            else if(input==0)
            {
                return;
            }
            else
            {
                Console.WriteLine("wrong format");
            }
        }
    }
}