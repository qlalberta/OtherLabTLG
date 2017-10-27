using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Roscoe_problem
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] a = { 624, 52, -155, 13, 9 };
//            int Sum = 0;
//            float Avg = (float)Sum / (a.Length);

//            //print out the array
//            Console.Write("Here is the array: ");
//            for (int i = 0; i < a.Length; i++)
//            {
//                Console.Write(a[i] + " ");
//            }
//            Console.WriteLine();

//            //print out the average
//            for (int i = 0; i < a.Length; i++)
//            {
//                Sum += a[i];
//            }
//            Console.WriteLine();
//            Console.WriteLine("The average of all the numbers is: {0}", Avg);

//            //sort the array
//            Array.Sort(a);           

//            //print out the product and Quotient
//            int Product = a[0] * a[1];
//            int Quotient = (a[a.Length - 1]) / (a[a.Length - 2]);

//            Console.WriteLine();
//            Console.WriteLine
//                ("The product of the smallest two numbers is: {0}", Product);
//            Console.WriteLine();
//            Console.WriteLine
//                ("The quotient of the largest two numbers is: {0}", Quotient);
//        }
//    }
//}

namespace Roscoe_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 624, 52, -155, 13, 9 };
            int Sum = 0;
            float Avg = (float)Sum / (a.Length);

            //print out the array
            Console.Write("Here is the array: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            //print out the sum
            float GetSum(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Sum += array[i];
                }
                return Sum;
            }

            Console.WriteLine();
            Console.WriteLine
                ("The sum of all the numbers is: {0}", GetSum(a));
            //print out the average

            float GetAverage(int[] array)
            {
                return Avg = (float)Sum / (array.Length);
            }
            Console.WriteLine();
            Console.WriteLine
                ("The average of all the numbers is: {0}", GetAverage(a));

            //sort the array
            Array.Sort(a);

            //print out the product and Quotient

            int GetProduct(int[] array)
            {
                int Product = array[0] * array[1];
                return Product;
            }

            int GetQuotient(int[] array)
            {               
                int Quotient = (array[array.Length - 1]) / (a[array.Length - 2]);
                return Quotient;
            }
            Console.WriteLine();
            Console.WriteLine
                ("The product of the smallest two numbers is: {0}", GetProduct(a));
            Console.WriteLine();
            Console.WriteLine
                ("The quotient of the largest two numbers is: {0}", GetQuotient(a));
        }
    }
}