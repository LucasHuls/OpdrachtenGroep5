using System;

namespace opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hier kan je mee berekenen of ja aan het examen mee mag doen");
            
            Console.Write("hoeveel punten heb je voor wiskunde gehaald: ");
            int wis = Convert.ToInt32(Console.ReadLine());
            Console.Write("hoeveel punten heb je voor scheikunde gehaald: ");
            int sche = Convert.ToInt32(Console.ReadLine());
            Console.Write("hoeveel punten heb je voor natuurkunde gehaald: ");
            int nat = Convert.ToInt32(Console.ReadLine());
            int totaal = (wis + sche + nat);
            

            if (wis >= 60){
                if (sche >= 60){ 
                    if (nat >= 60){
                        Console.WriteLine("je bent geslaagd");
                        
                    }
                }
            }
           
            if (totaal >= 180)
                Console.WriteLine("je bent geslaagd");
            
            else 
                Console.WriteLine("je bent gezakt");

            Console.ReadLine();


            




        }
    }
}
