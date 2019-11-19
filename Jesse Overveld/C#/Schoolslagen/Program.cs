using System;

namespace Schoolslagen
{
    class Program
    {
        static void Main(string[] args)
        {
            int Wiskunde;
            int Scheikunde;
            int Natuurkunde;
            Console.WriteLine("Een kandidaat mag deelnemen aan het examen als aan één van de volgende voorwaarden is voldaan:");
            Console.WriteLine("De score voor Wiskunde is 60 of hoger en de score van Scheikunde of Natuurkunde is 60 of hoger.");
            Console.WriteLine("OF");
            Console.WriteLine("Het totaal van de punten is 180 of meer.");
            Console.WriteLine("");
            Console.WriteLine("Voor geen van de vakken mag de score lager zijn dan 40 punten.");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Score wiskunde (1-100): ");
            Wiskunde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Score scheikunde (1-100): ");
            Scheikunde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Score natuurkunde (1-100): ");
            Natuurkunde = Convert.ToInt32(Console.ReadLine());

            if (Wiskunde >= 60 && Scheikunde >= 60 || Wiskunde >= 60 && Natuurkunde >= 60) {
                Console.WriteLine("Je mag meedoen!");
            }
            else if ((Wiskunde += Scheikunde += Natuurkunde) < 180) {
                Console.WriteLine("Je mag niet meedoen!");
            }
            else if (Wiskunde < 40 || Scheikunde < 40 || Natuurkunde < 40) {
                Console.WriteLine("Je mag niet meedoen!");
            }
            else if ((Wiskunde += Scheikunde += Natuurkunde) > 180) {
                Console.WriteLine("Je mag meedoen!");
            }
        }
    }
}
