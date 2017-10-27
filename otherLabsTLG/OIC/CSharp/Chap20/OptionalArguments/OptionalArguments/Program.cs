using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptionalArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = Book.InitBooks();
            ShowBooks(books);
            ShowBooks(books, 2006);
            ShowBooks(books, 2006, 2008);
        }
        static void ShowBooks(List<Book> books, int start = 1900, int end = 2100)
        {
            foreach (var bk in books)
            {
                if (bk.Year >= start && bk.Year <= end)
                    Console.WriteLine(bk);
            }
            Console.WriteLine("---------------------------");
        }
    }
}
