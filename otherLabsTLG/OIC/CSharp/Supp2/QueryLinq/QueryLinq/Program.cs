using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryLinq
{
	class Program
	{
		private static List<Book> books;

		static void Main(string[] args)
		{
			books = Book.InitBooks();
			all();
			filter();
			order();
			aggregate();
			array();
		}
		private static void ShowBook(Book bk)
		{
			Console.WriteLine(bk.ToString());
		}
		private static void all()
		{
			var query = from bk in books
							select bk;
			foreach (var bk in query)
				ShowBook(bk);
		}
		private static void filter()
		{
			Console.WriteLine("filter");
			var query = from bk in books
							where bk.Year < 2009 && bk.Price > 25m
							select bk;
			foreach (var bk in query)
				ShowBook(bk);
		}
		private static void order()
		{
			Console.WriteLine("order");
			var query = from bk in books
							where bk.Year > 2004
							orderby bk.Price descending
							select bk;
			foreach (var bk in query)
				ShowBook(bk);
		}
		private static void aggregate()
		{
			Console.WriteLine("aggregate");
			var query = from bk in books
							select bk.Price;
			Console.WriteLine("Count = {0}", query.Count());
			Console.WriteLine("Sum = {0}", query.Sum());
			Console.WriteLine("Max = {0}", query.Max());
			Console.WriteLine("Min = {0}", query.Min());
		}
		private static void array()
		{
			Console.WriteLine("array");
			var query = from bk in books
							select bk;
			Book[] array = query.ToArray<Book>();
			int count = array.Length;
			Console.WriteLine("{0} books", count);
			Console.WriteLine("First book:");
			ShowBook(array[0]);
			Console.WriteLine("Last book:");
			ShowBook(array[count - 1]);
		}
	}
}
