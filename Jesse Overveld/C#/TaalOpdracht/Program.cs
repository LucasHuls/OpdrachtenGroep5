using System;

namespace TaalOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            int Keuzenummer;

            Console.WriteLine("Voer een nummer in om een taal te kiezen.");
            Console.WriteLine("1: Nederlands");
            Console.WriteLine("2: Duits");
            Console.WriteLine("3: Engels");
            Console.WriteLine("4: Frans");
            Console.WriteLine("5: Spaans");
            Console.WriteLine("6: Andere talen");
            Keuzenummer = Convert.ToInt32(Console.ReadLine());

            if (Keuzenummer == 1) {
                Console.WriteLine("De huidige maand is Maart.");
            }
            else if (Keuzenummer == 2) {
                Console.WriteLine("Der aktuelle Monat ist März.");
            }
            else if (Keuzenummer == 3) {
                Console.WriteLine("The current month is March.");
            }
            else if (Keuzenummer == 4) {
                Console.WriteLine("Le mois en cours est mars.");
            }
            else if (Keuzenummer == 5) {
                Console.WriteLine("El mes actual es marzo.");
            }
            else if (Keuzenummer == 6) {
                Console.WriteLine("Voer een andere taal in:");
                Console.ReadLine();
                Console.WriteLine("Bu ay Mart ayı.");
            }
        }
    }
 }
