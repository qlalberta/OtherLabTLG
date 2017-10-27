// Course.cs

using System;
using System.Collections;

public class Course : ICloneable
{
	public string Title;
	public ArrayList Roster;
	public Course(string title)
	{
		Title = title;
		Roster = new ArrayList();
	}
	public void AddStudent(string name)
	{
		Roster.Add(name);	
	}
	public void Show(string caption)
	{
		Console.WriteLine("-----{0}-----", caption);
		Console.WriteLine("Course : {0} with {1} students", Title, Roster.Count);
		foreach (string name in Roster)
		{
			Console.WriteLine(name);
		}
	}
	public Course ShallowCopy()
	{
		return (Course) this.MemberwiseClone();
	}
	public object Clone()
	{
		Course course = new Course(Title);
		course.Roster = (ArrayList) Roster.Clone();
		return course;
	}
}
