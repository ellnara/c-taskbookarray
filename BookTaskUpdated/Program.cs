using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the book count:");
            int say = int.Parse(Console.ReadLine());
            Console.Clear();
            Book[] books = new Book[say];
            for (int i = 0; i < books.Length; i++)
            {
                Book book = new Book();
                Console.WriteLine("Enter the book name:");
                book.Name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the book price:");
                book.Price = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Enter the book genre:");
                book.Genre = Console.ReadLine();
                Console.Clear();
                books[i] = book;
            }
            while (true)
            {
                Console.WriteLine($"Menu: \n1. Kitablari qiymete gore filterle \n2. Butun kitablari goster \n3. Programi bagla");
                int menuInput = int.Parse(Console.ReadLine());
                if (menuInput == 1)
                {
                    Console.WriteLine("Enter min price: ");
                    double minPrice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter max price");
                    double maxPrice = int.Parse(Console.ReadLine());
                    Book temp;
                    int count = 0;
                    for (int i = 0; i < books.Length - 1; i++)
                    {
                        for (int j = i + 1; j < books.Length; j++)
                        {
                            if (books[i].Price > books[j].Price)
                            {
                                temp = books[i];
                                books[i] = books[j];
                                books[j] = temp;
                            }
                        }
                    }
                    foreach (var item in books)
                    {
                        if (item.Price >= minPrice && item.Price <= maxPrice)
                        {
                            count++;
                            Console.WriteLine($"Book Number: {item.no} \nName: {item.Name} \nGenre: {item.Genre} \nPrice: {item.Price}\n");
                        }
                    }
                    Console.WriteLine($"{count} out of {say} books found");
                }
                else if (menuInput == 2)
                {
                    foreach (var item in books)
                    {
                        Console.WriteLine($"Name: {item.Name} \nGenre: {item.Genre} \nPrice: {item.Price}");
                    }
                }
                else if (menuInput == 3)
                {
                    break;
                }
            }
        }
    }
}
