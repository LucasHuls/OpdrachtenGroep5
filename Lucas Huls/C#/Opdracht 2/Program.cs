//Autodealer Zelf-Menu - LucasHuls
using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
//Intro
            Console.WriteLine("Welkom bij de zelfmenu van de autodealer.");
            Console.Write("Wat is uw naam? ");
            string naam = Console.ReadLine();
            Console.Write("Wat is de standaardprijs van de gewilde auto? ");
            int Prijs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Loop alle stappen zorgvuldig door.");
            Console.WriteLine("Aan het eind word uw prijs berekend.");
            Console.WriteLine("Antwoord alstublieft met ja en nee om problemen te voorkomen.");
//Extra's vragen
            Console.Write("Wilt u een metallic lak op de auto? (5% verhoging) ");
            string metallic = Console.ReadLine();
            Console.Write("Wilt u leren bekleding? (5% verhoging) ");
            string bekleding = Console.ReadLine();
            Console.Write("Wilt u een automatische transmissie? (+1000) ");
            string automaat = Console.ReadLine();
//Procent Berekeningen
            int vijfper = (Prijs / 100 ) * 5;
//Extra's Berekeningen
        if (metallic == "ja"){
            Prijs = Prijs + vijfper;
        }
        if (bekleding == "ja"){
            Prijs = Prijs + vijfper;
        }
        if (automaat == "ja"){
            Prijs = Prijs + 1000;
        }
//Procent Berekeningen
            int Prijsincl = Prijs + ( (Prijs / 100 ) * 21 );
//Totaal Bedragen Berekeningen
        Console.WriteLine("BTW: 21%");
        Console.WriteLine("Bedrag exclusief BTW: '{0}')", Prijs);
        Console.WriteLine("Totaalbedrag: '{0}' )", Prijsincl);
        }
    }
}