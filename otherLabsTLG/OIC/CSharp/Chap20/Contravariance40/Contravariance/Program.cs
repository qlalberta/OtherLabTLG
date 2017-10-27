using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contravariance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = Book.InitBooks();
            ShowBooks(books);

            // Sort the books by title
            // TitleComparer does a compare on BookTitle
            // We gain the compare on Book by contravariance
            // Only valid in .NET 4.0!
            TitleComparer comp = new TitleComparer();
            books.Sort(comp);
            ShowBooks(books);
        }
        static void ShowBooks(List<Book> books)
        {
            foreach (Book b in books)
                Console.WriteLine(b);
            Console.WriteLine("--------------------------");
        }
    }
}
