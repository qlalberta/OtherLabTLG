// ForEachLoop.cs

using System;

public class ForEachLoop
{
    public static int Main(string[] args)
    {
        int[] primes = { 2, 3, 5, 7, 11, 13 };
        int sum = 0;
        foreach (int prime in primes)
        {
            Console.Write("{0} ", prime);
            sum += prime;
        }
        Console.WriteLine();
        return 0;
    }
}
