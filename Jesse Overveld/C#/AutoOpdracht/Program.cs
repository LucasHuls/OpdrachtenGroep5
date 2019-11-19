using System;

namespace AutoOpdracht
{
    public class Program
    {
        public static void Main()
        {
            int Vijfprocent;
            int VollePrijs;
            int Standaardprijs;
            string Naam;
            string Metallic;
            string LeerBekleding;
            string Automaat;

            Console.WriteLine("Hallo, welkom bij Hans Autodealers inc.");
            Console.WriteLine("Wat is uw naam?");
            Naam = Console.ReadLine();

            Console.WriteLine("Wat is de standaardprijs van uw auto in euros?");
            Standaardprijs = Convert.ToInt32(Console.ReadLine());
            Vijfprocent = (Standaardprijs / 100 * 5);
            VollePrijs = Standaardprijs;

            Console.WriteLine("Er zijn extra toevoegingen mogelijk aan uw auto!");
            Console.WriteLine("Wilt u een Metallic lak voor 5% verhoging van de standaardprijs? (Ja/Nee)");
            Metallic = Console.ReadLine();
            
            {
            if (Metallic == "Ja")
                VollePrijs += Vijfprocent;
            }

            Console.WriteLine("Wilt u leren bekleding voor 5% verhoging van de standaardprijs? (Ja/Nee)");
            LeerBekleding = Console.ReadLine();
            
            {
            if (LeerBekleding == "Ja")
                VollePrijs += Vijfprocent;
            }

            Console.WriteLine("Wilt u automatische schakeling voor een verhoging van 1000.- euro? (Ja/Nee)");
            Automaat = Console.ReadLine();
        
            if (Automaat == "Ja")
            {
                VollePrijs += 1000;
            }

            Console.WriteLine("{0}, uw te betalen bedrag is: {1}", Naam, VollePrijs);
        }
    }
}