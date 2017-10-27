using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Class1
{

    public int[] numbers;
    public Class1(int[] numbers)
    {
        this.numbers = numbers;
    }
    public int Sum(int[] numbers)
    {
        int size = numbers.Length;
        Array.Sort(numbers);
        int Sum = numbers[0] + numbers[1];
        return Sum;
    }

}

public class Class2
{
    static void Main()
    {
        Console.WriteLine("Please provide the size of an array");
        int Size = Convert.ToInt32(Console.ReadLine());
        int[] UserArray = new int[Size];
        int count = 1;
        Console.WriteLine("Please input integer numbers for your array: ");
        for (int i = 0; i < Size; i++)
        {
            Console.Write("Number {0}: ", count++);
            UserArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Class1 sumNumbers = new Class1(UserArray);
        Console.WriteLine(sumNumbers.Sum(UserArray));
    }
}




