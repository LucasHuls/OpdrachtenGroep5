using System;

namespace opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Nederlands kies 1");
            Console.WriteLine("duits kies 2");
            Console.WriteLine("Engels kies 3");
            Console.WriteLine("Frans kies 4");
            Console.WriteLine("Spaans kies 5");
            Console.WriteLine("Maleis kies 6");
            Console.Write("welke taal kies je?: ");
            string taal = Console.ReadLine();

            if (taal == "1")
                Console.WriteLine("De huidige maand is Maart.");

            if (taal == "2")
                Console.WriteLine("Der aktuelle Monat ist März");

            if (taal == "3")
                Console.WriteLine("The current month is March ");

            if (taal == "4")
                Console.WriteLine("Le mois en cours est mars");

            if (taal == "5")
                Console.WriteLine("El mes actual es marzo");

            if (taal == "6")
                Console.WriteLine("bulan semasa adalah bulan Mac");

            Console.ReadLine();
            


        }
    }
}
