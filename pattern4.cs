using System;

class Program
{
    static void Main()
    {
        int n = 5; // Number of lines

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j); // Print numbers from 1 to i
            }
            Console.WriteLine(); // Move to next line
        }
    }
}
