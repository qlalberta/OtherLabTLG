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
        fixed (int* ap = myHeapArray)
        {
            // Print the address while the location of the array is frozen in memory
            Console.WriteLine($"Address of heap array: {(ulong)ap,16:X}");

            {
                // Stack is not garbage collected so no need for fixed
                int* myStackArray = stackalloc int[20];
                Console.WriteLine($"Address of stack array: {(ulong)myStackArray,16:X}");
                // Copy heap array contents onto stack array
                int* hp = &ap[0];
                int* sp = &myStackArray[0];
                for (int i = 0; i < myHeapArray.Length; i++, hp++, sp++)
                {
                    sp[0] = hp[0];
                }
                // Print the values and their addresses
                for (int i = 0; i < 20; i++, sp++)
                {
                    Console.WriteLine($"{myStackArray[i],4}  {(ulong)&myStackArray[i],16:X}");
                }
            }
            Console.WriteLine();
        }

        Buffer b;
        b.myFixedArray[0] = 1;
        b.myFixedArray[1] = 2;
        b.myFixedArray[2] = 3;
        b.myFixedArray[3] = 4;
        // Print the values and their addresses
        for (int* ip = &b.myFixedArray[0]; ip <= &b.myFixedArray[19]; ip++)
        {
            Console.WriteLine($"{*ip,4}  {(ulong)ip,16:X}");
        }
    }
    public unsafe struct Buffer
    {
        public fixed int myFixedArray[20];
    }
}