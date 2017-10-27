using System;
using System.Collections.Generic;

public class Book
{
	public string Title { get; set; }
	public int Year { get; set; }
	public decimal Price { get; set; }
	
	public Book(string t, int y, decimal p)
	{
		Title = t;
		Year = y;
		Price = p;
	}
	public override string ToString()
	{
		return string.Format("{0:C}  {1}  {2}",
			Price, Year, Title);
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
		books.Add(new Book("WPF in Action", 2009, 29.99m));
		books.Add(new Book("Sivlerlight 3 Unleashed", 2009, 24.99m));
		books.Add(new Book("Software Testing", 2005, 24.99m));
		books.Add(new Book("Introduction to SQL", 2005, 39.99m));
		books.Add(new Book("JavaServer Pages", 2007, 35.00m));
		books.Add(new Book("Introduction to Java", 2008, 40.00m));
		books.Add(new Book("PHP Programming", 2004, 45.00m));
		books.Add(new Book("C# Programming", 2010, 35.00m));
		books.Add(new Book("XML Fundamentals", 2003, 30.00m));
		return books;
	}
}
