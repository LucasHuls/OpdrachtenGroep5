//Geslaagd of Gezakt - LucasHuls
using System;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cijfer Wiskinde: ");
            int Wiskunde = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cijfer Natuurkunde: ");
            int Natuurkunde = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cijfer Scheikunde: ");
            int Scheikunde = Convert.ToInt32(Console.ReadLine());
            int Totaal = (Wiskunde + Natuurkunde + Scheikunde);

            if (Wiskunde >= 60){
                if (Natuurkunde >= 60){
                    if (Scheikunde >= 60){
                        Console.WriteLine("Je bent Geslaagd!");
                    }
                }
            }
            if (Totaal > 180){
                Console.WriteLine("Je bent Geslaagd!");
            }
            else{
                Console.WriteLine("Je bent Gezakt!");
            }

        }
    }
}
