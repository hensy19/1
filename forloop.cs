using System;

class Program
{
    static void Main()
    {
        int count = 0;
        for (int i = 1; count < 50; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                count++;
            }
            else
            {
                // Optional: You can leave this else block empty or use it for debugging
            }
        }
    }
}
