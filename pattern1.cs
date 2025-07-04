using System;

class Program
{
    static void Main()
    {
        int rows = 5;
        int columns = 5;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Move to next line
        }
    }
}
