using System;

class Program
{
    static void Main()
    {
        int n = 5; // Total number of rows

        for (int i = 1; i <= n; i++)
        {
            // Print spaces
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine(); // Move to next line
        }
    }
}
