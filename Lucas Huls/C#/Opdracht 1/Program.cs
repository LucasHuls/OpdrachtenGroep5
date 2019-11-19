//BMI Calc - LucasHuls
using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Body Mass Index Berekenen");
            Console.WriteLine("By Lucas Huls");
            Console.WriteLine("=========================");

			Console.Write("Wat is je gewicht in kilogram? ");
            int Gewicht = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wat is je lengte in cm? ");
            int lengte = Convert.ToInt32(Console.ReadLine());

            double bmi = Gewicht / ( ( lengte / 100.0 ) * ( lengte / 100.0 ) );
            Console.WriteLine("Je BMI = '{0}' ", bmi);

            Console.Write("Klik op Enter om het scherm te sluiten...");
            Console.ReadLine();
        }
    }
}
