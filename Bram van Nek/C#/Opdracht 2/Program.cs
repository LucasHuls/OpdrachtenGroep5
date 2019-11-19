using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("goedendag, antwoord alleen met ja of nee.");

            Console.Write("wat is uw naam? : ");
            string naam = Console.ReadLine();

            Console.Write("wat is de begin prijs van uw auto? : ");
            int prijs = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("wilt u metallic lak? : ");
            string lak = Console.ReadLine();

            Console.Write("wilt u lerenbekleding? : ");
            string lerenbekleding = Console.ReadLine();

            Console.Write("wilt u een automaat? : ");
            string automaat = Console.ReadLine();

            int vijfprocent = (prijs / 100 ) * 5;

            if (lak == "ja"){
                prijs = prijs + vijfprocent;
            }
            if (lerenbekleding == "ja"){
                prijs  = prijs + vijfprocent;
            }
            if (automaat == "ja"){
                prijs = prijs + 1000;
            }

            int belasting = ( prijs + ( prijs / 100) * 21);

            Console.WriteLine("prijs exclusief btw: '{0}'", prijs);
            Console.WriteLine("prijs inclusief btw: '{0}'", belasting);

            Console.ReadLine();
        }
    }
}
