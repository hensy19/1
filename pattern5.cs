using System;

class Program
{
    static void Main()
    {
        int n = 5;               // Maximum stars in the middle line
        int totalLines = 2 * n - 1; // Total number of lines (9 for n = 5)

        for (int i = 1; i <= totalLines; i++)
        {
            int starsToPrint = i <= n ? i : totalLines - i + 1;

            Console.WriteLine(new string('*', starsToPrint));
        }
    }
}
