// CopyDemo.cs

using System;
using System.Collections;

public class CopyDemo
{
	private static Course c1, c2;
	public static void Main()
	{
		Console.WriteLine("Copy is done via c2 = c1");
		InitializeCourse();
		c1.Show("original");
		c2 = c1;
		c2.Show("copy");
		c2.Title = ".NET Programming";
		c2.AddStudent("Charlie");
		c2.Show("copy with changed title and new student");
		c1.Show("original");

		Console.WriteLine("\nCopy is done via c2 = c1.ShallowCopy()");
		InitializeCourse();
		c2 = c1.ShallowCopy();
		c2.Title = ".NET Programming";
		c2.AddStudent("Charlie");
		c2.Show("copy with changed title and new student");
		c1.Show("original");

		Console.WriteLine("\nCopy is done via c2 = c1.Clone()");
		InitializeCourse();
		c2 = (Course) c1.Clone();
		c2.Title = ".NET Programming";
		c2.AddStudent("Charlie");
		c2.Show("copy with changed title and new student");
		c1.Show("original");
	}
	private static void InitializeCourse()
	{
		c1 = new Course("Intro to C#");
		c1.AddStudent("John");
		c1.AddStudent("Mary");
	}
}