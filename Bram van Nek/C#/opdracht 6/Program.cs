using System;

namespace opdracht_6
{
    class Program
    {
        static void Main(string[] args)
        {
        int num1 = 0;
        int num2 = 1;
        int sum = 1;

        while (num1 <= 121393){
            sum = num1 + num2;
            num1 = num2;
            num2 = sum;
            Console.WriteLine(num2);
        }
        }
    }
}
