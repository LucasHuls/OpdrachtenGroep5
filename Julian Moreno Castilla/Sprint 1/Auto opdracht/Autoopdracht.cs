using System;

namespace Auto_opdracht
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Wat is je volledige naam?");
        string naam = Console.ReadLine();
        Console.WriteLine("Wil je de optie Metallic lak?");
        string lak = Console.ReadLine();
        Console.WriteLine("Wil je leren bekleding?");
        string bekleding = Console.ReadLine();
        Console.WriteLine("Wil je een automaat ter waarde van 1000,- extra?");
        string automaat = Console.ReadLine();
        Console.WriteLine("Het totaal-bedrag is 29,500,-.");
        Console.WriteLine("Met de BTW (21%) is het totaal bedrag 35,695 incl BTW.");
        
        
   if (automaat == "nee"){
       Console.WriteLine("Je bedrag is de standaardprijs van 25,000,-");
   }
   if (lak == "nee"){
       Console.WriteLine("Prijs = 25,000,-");
   }
   if (bekleding == "nee"){
       Console.WriteLine("Standaardprijs = 25,000,-");
   }
if (automaat == "ja"){
    Console.WriteLine("(29,500 excl BTW,-)");

}

}  

    
}


   
    }


