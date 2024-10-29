namespace System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nEven Numbers are:");
        for (int i = 1; i <= 50; i++)
        {
            if(i % 2 == 0){
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Odd Numbers are:");
        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
