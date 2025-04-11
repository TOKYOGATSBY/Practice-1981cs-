using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        long totalDiag = n * (n - 3) / 2;

        long parallelCount;
        if (n == 4)
        {
            parallelCount = 0;
        }
        else if (n == 5)
        {
            parallelCount = 0;
        }
        else if (n == 6)
        {
            parallelCount = 6;
        }
        else
        {
            parallelCount = totalDiag;
        }

        long perpCount;
        if (n % 2 == 0)
        {
            perpCount = totalDiag;
        }
        else
        {
            perpCount = 0;
        }

        Console.WriteLine($"{parallelCount} {perpCount}");
    }
}
