// EchoName.cs
//
// Prompts user to enter name and then
// prints out greeting using name

using System;

class Echo
{
 public static void Main(string[] args)
 {
   InputWrapper iw = new InputWrapper();
   string name = iw.getString("Enter your name: ");
   Console.WriteLine("Hello, " + name);
 }
}
