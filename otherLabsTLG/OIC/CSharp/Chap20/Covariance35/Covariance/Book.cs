using System;
using System.Collections.Generic;

public class Book
{
	public string Title { get; set; }
	public int Year { get; set; }

	public Book(string t, int y)
	{
		Title = t;
		Year = y;
	}
	public override string ToString()
	{
		return Title + " (" + Year + ")";
	}
	public override bool Equals(object obj)
	{
		Book b = obj as Book;
		bool result;
		if (b != null && b.Title == this.Title)
			result = true;
		else
			result = false;
		return result;
	}

	static public List<Book> InitBooks()
	{
		List<Book> books = new List<Book>();
		books.Add(new Book("WPF in Action", 2009));
		books.Add(new Book("Silverlight 3 Unleashed", 2009));
		books.Add(new Book("Software Testing", 2008));
		books.Add(new Book("Introduction to SQL", 2005));
		books.Add(new Book("JavaServer Pages", 2007));
		books.Add(new Book("Introduction to Java", 2008));
		books.Add(new Book("PHP Programming", 2009));
      books.Add(new Book("Fundamentals of SQL", 2004));
      return books;
	}
}
