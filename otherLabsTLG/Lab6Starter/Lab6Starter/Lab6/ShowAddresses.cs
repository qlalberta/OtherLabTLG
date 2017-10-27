using System;

public class ShowAddresses
{

    public static unsafe void Main()
    {
        // Declare an integer variable (it will be allocated on the stack)
        int myInt = 0x66;
        // Declare a pointer to it
        int* p;
        // Get the address of the variable and show it
        p = &myInt;
        Console.WriteLine($"Address of variable : {(ulong)p,16:X}");

        // Create and initialize an integer array (it will be allocated on the heap)
        int[] myHeapArray = new int[5] { 1, 2, 3, 4, 5 };

        // Note the array pointer is being declared in the fixed statement
        // and initialized by copying the array reference above
        fixed (int* hPtr = myHeapArray)
        {
            // Print the address while the location of the array is frozen in memory
            Console.WriteLine($"Address of heap array: {(ulong)hPtr,16:X}");
            for (int* ha = hPtr; ha <= &hPtr[4]; ha++)
            {
                Console.WriteLine($"{*ha,4}  {(ulong)ha,16:X}");
            }
            Console.WriteLine();

            int* StackArray = stackalloc int[20];
            Console.WriteLine($"Address of stack array: {(ulong)StackArray,16:X}");
            int* sp = &StackArray[0];
            int* hp = &hPtr[0];
            //for (int i = 0; i < myHeapArray.Length; i++, sp++, hp++)
            //{
            //    StackArray[i] = myHeapArray[i];
            //}
            for (int* nhp = hp; nhp <= &hPtr[4]; sp++, nhp++)
            {
                *sp = *nhp;
            }
            for (int i = 0; i < 20; i++, sp++)
            {
                Console.WriteLine
 ($"Content of each element:{StackArray[i],10} " +
 $"Address of each element: {(ulong)&StackArray[i],16:X}");
            }

        }
    }
}