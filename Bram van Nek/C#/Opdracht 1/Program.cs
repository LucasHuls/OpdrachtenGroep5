using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("wat is je gewicht? :");
            int gewicht = Convert.ToInt32(Console.ReadLine());

            Console.Write("wat is je lengte? :");
            int lengte = Convert.ToInt32(Console.ReadLine());

            double BMI = gewicht / ( ( lengte / 100.0 ) * ( lengte / 100.0 ) );
            Console.WriteLine("dit is je bmi: '{0}'", BMI);

            Console.WriteLine("klik op enter om te sluiten");
            Console.ReadLine();


        }
    }
}
