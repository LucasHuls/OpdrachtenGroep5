using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; 
            int keren; 
            int Getal1 = 0; // Getal 1 is het opgetelde getal
            int Getal2 = 1; // Getal 2 en 3 zijn de twee getallen die opgeteld worden
            int Getal3 = 0;
            keren = 25;
            Console.WriteLine(Getal1);
            Console.WriteLine(Getal2);
            for (i = 0; i <= keren; i++)
            {
                Getal3 = Getal1 + Getal2;
                Console.WriteLine(Getal3);
                Getal1 = Getal2;
                Getal2 = Getal3;
            }
            Console.ReadLine();
 
        }
    }
}