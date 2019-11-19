//Taal-Menu - LucasHuls
using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 = Nederlands");
            Console.WriteLine("2 = Duits");
            Console.WriteLine("3 = Engels");
            Console.WriteLine("4 = Frans");
            Console.WriteLine("5 = Spaans");
            Console.WriteLine("6 = Indonesisch");
            Console.Write("Kies een taal (Nummer invoeren): ");
            string Taal = Console.ReadLine();
            if (Taal == "1"){
                Console.WriteLine("De huidige maand is Maart.");
            }
            if (Taal == "2"){
                Console.WriteLine("Der aktuelle Monat ist März.");
            }
            if (Taal == "3"){
                Console.WriteLine("The current month is March.");
            }
            if (Taal == "4"){
                Console.WriteLine("Le mois en cours est mars.");
            }
            if (Taal == "5"){
                Console.WriteLine("El mes actual es marzo.");
            }
            if (Taal == "6"){
                Console.WriteLine("Bulan ini adalah Maret.");
            }
        }
    }
}
