//Schikkeljaar - LucasHuls2002
using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schikkeljaar Berekeningen");
            string beginjaar = "1898";
            string eindjaar = "2020";
            int start = int.Parse(beginjaar);
            int eind = int.Parse(eindjaar);
            for (int i = start; i <= eind; i++)
            {
                if (i % 100 == 0)
                {
                    if (i % 400 == 0)
                    Console.WriteLine("Het jaar {0} is een schikkeljaar", i);
                }
                    
                else if (i % 4 == 0)
                    Console.WriteLine("Het jaar {0} is een schikkeljaar", i);
            }
            Console.ReadLine();
        }
    }
}