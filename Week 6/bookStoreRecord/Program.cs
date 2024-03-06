using System;

namespace bookStoreRecord
{
    public record Bookstore(int bookNum, string Title, string Author, double Price);

    class Program
    {
        static void Main(string[] args)
        {
            // Create bookstroe objs
            var book1 = new Bookstore(1, "Kirby Manga Mania, Vol 1", "Hirokazu Hikawa", 9.99);
            var book2 = new Bookstore(2, "Kirby Manga Mania, Vol 2", "Hirokazu Hikawa", 9.99);
            var book3 = new Bookstore(3, "Kirby Manga Mania, Vol 3", "Hirokazu Hikawa", 9.99);

            // Display 
            Console.WriteLine("First book:");
            DisplayBookInfo(book1);
            Console.WriteLine();

                Console.WriteLine("Second book:");
                DisplayBookInfo(book2);
                Console.WriteLine();

                    Console.WriteLine("Third book:");
                    DisplayBookInfo(book3);
                    Console.WriteLine();
        }

        static void DisplayBookInfo(Bookstore book)
        {
            Console.WriteLine($"ID: {book.bookNum}");
                Console.WriteLine($"Title: {book.Title}");
                    Console.WriteLine($"Author: {book.Author}");
                        Console.WriteLine($"Price: {book.Price:C}");
        }
    }
}