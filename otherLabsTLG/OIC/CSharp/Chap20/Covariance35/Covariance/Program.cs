using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Covariance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = Book.InitBooks();
            List<string> titles = GetTitles(books);
            ShowObjects(books);
            ShowObjects(titles);
        }
        static List<string> GetTitles(List<Book> books)
        {
            List<string> titles = new List<string>();
            foreach (Book b in books)
                titles.Add(b.Title);
            return titles;
        }
        static void ShowObjects(IEnumerable<object> objs)
        {
            foreach (object obj in objs)
                Console.WriteLine(obj);
            Console.WriteLine("------------------------");
        }
    }
}
