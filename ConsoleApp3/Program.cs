using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Number\tSquare\tCube");

        for (int i = 1; i <= 20; i++)
        {
            int square = i * i;
            int cube = i * i * i;
            Console.WriteLine($"{i}\t{square}\t{cube}");
        }
    }
}
