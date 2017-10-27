using System;
using System.Collections.Generic;

public class BookTitle
{
    public string Title { get; set; }
    public BookTitle(string t = "")
    {
        Title = t;
    }
    public override string ToString()
    {
        return Title;
    }
}

public class TitleComparer : IComparer<BookTitle>
{
    public int Compare(BookTitle t1, BookTitle t2)
    {
        return (t1.Title.CompareTo(t2.Title));
    }
}

public class Book : BookTitle
{
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
