using System;

namespace DRIEGETALLEN
{
    class Program
    {
        static void Main(string[] args)
        {
            double Getaleen;
            double Getaltwee;
            double Getaldrie;
            Console.WriteLine("Voer getal 1 in: ");
            Getaleen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voer getal 2 in: ");
            Getaltwee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voer getal 3 in: ");
            Getaldrie = Convert.ToInt32(Console.ReadLine());

            if (Getaleen > Getaldrie && Getaltwee > Getaldrie)
            {
                Console.WriteLine("Één van de eerste twee getallen is groter dan de derde.");
            }
            else if (Getaleen < Getaldrie || Getaltwee < Getaldrie)
            {
                Console.WriteLine("Het derde getal is niet het kleinste van de drie.");
            }
            else if (Getaleen == Getaldrie && Getaltwee == Getaldrie)
            {
                Console.WriteLine("De getallen zijn hetzelfde");
            }
        }
    }
}
