using System;
 
class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Geef het nummer alsjeblieft:");
        int n = int.Parse(Console.ReadLine());
 
        if (n == 0)
        {
            Console.WriteLine("Verkeerde combinatie!");
            return;
        }
        else if (n == 1)
        {
            Console.WriteLine(0);
            return;
        }
 
        int x1 = 0;
        int x2 = 1;
        Console.Write("{0} {1} ", x1, x2);
 
        for (int i = 2; i < n; i++)
        {
            int x3 = x1 + x2;
            Console.Write("{0} ", x3);
            x1 = x2;
            x2 = x3;
        }
        Console.WriteLine();
    }
}
