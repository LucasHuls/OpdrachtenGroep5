//Schikkeljaar Calc - LucasHuls2002
using System;

namespace Opdracht_6
{
    class Program
    {
        static void Main(string[] args)
        {
//Tijdelijke Variabelen
        int num1 = 0;
        int num2 = 1;
        int sum = 1;
//Loop tot 25 Getallen
        while (num1 <= 121393){
            sum = num1 + num2;
            num1 = num2;
            num2 = sum;
            Console.WriteLine(num2);
    }
        }   
    }
}
