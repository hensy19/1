using System;

class Program
{
    static void Main()
    {
        int n = 5; // Total number of stars in the first row

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Move to next line
        }
    }
}
