using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Exercise1
{
    static void Main(string[] args)
    {
        Console.Write("Please input a string: ");
        string a = Console.ReadLine();
        string[] str = a.Split();
        for (int i = 0; i < str.Length; i++)
        {
            char[] charArray = str[i].ToCharArray();
            foreach (char j in charArray)
            {
                Console.Write("{0} ", j);
            }
        }
        Console.Write(".");


    }
}



//class Exercise2
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Declare a simple structure: ");
//        Sum newSum = new Sum();
//        newSum.x = 12;
//        newSum.y = 34;
//        Console.WriteLine("The sum of x and y is: {0}", newSum.ShowSum());

//    }
//}

//public struct Sum
//{
//    public int x;
//    public int y;
//    public Sum(int x, int y)
//    {
//        this.x = x;
//        this.y = y;
//    }

//    public int ShowSum()
//    {
//        return (x + y);
//    }
//}


//class Exercise3
//{
//    static void Main(string[] args)
//    {
//        Employee[] EmployeeArray = new Employee[2];
//        Console.WriteLine("Create a New Structure and store data in an array: ");
//        Console.WriteLine();
//        for (int i = 0; i < EmployeeArray.Length; i++)
//        {
//            Console.Write("Name of the employee: ");
//            EmployeeArray[i].name = Console.ReadLine();

//            Console.Write("Input the day of the birth: ");
//            EmployeeArray[i].date.day = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Input the month of the birth: ");
//            EmployeeArray[i].date.month = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Input the year of the birth: ");
//            EmployeeArray[i].date.year = Convert.ToInt32(Console.ReadLine());
//            Show(i);
//        }


//        void Show(int i)
//        {
//            Console.WriteLine
//                ("The employee {0} was born on {1}/{2}/{3}.", EmployeeArray[i].name,
//                EmployeeArray[i].date.day, EmployeeArray[i].date.month,
//                EmployeeArray[i].date.year);
//        }
//    }
//}


//public struct Employee
//{
//    public string name;
//    public Date date;
//}

//public struct Date
//{
//    public int day;
//    public int month;
//    public int year;

//}

//using System.Text.RegularExpressions;

//class Exercise4
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Please input a sentence: ");
//        string a = Console.ReadLine().ToLower();
//        Regex regex = new Regex("[^a-z]");
//        a = regex.Replace(a, " ");
//        string[] str = a.Split();
//        char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'y' };
//        int countVowel = 0;
//        int countConsonant = 0;
//        for (int i = 0; i < str.Length; i++)
//        {
//            char[] charArray = str[i].ToCharArray();
//            foreach (char j in charArray)
//            {

//                if (vowel.Contains(j))
//                {
//                    countVowel++;
//                }
//                else
//                {
//                    countConsonant++;
//                }
//            }

//        }
//        Console.WriteLine("The total number of vowels in the tring is: {0}", countVowel);
//        Console.WriteLine
//            ("The total number of consonantss in the tring is: {0}", countConsonant);
//    }
//}
