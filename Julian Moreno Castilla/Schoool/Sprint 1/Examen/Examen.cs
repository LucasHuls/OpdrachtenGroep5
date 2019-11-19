using System;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je cijfer voor wiskunde?");
            double wiskunde = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Wat is je cijfer voor scheikunde?");
            double scheikunde = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Wat is je cijfer voor natuurkunde?");
            double natuurkunde = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Wat is je cijfer voor economie?");
            double economie = Convert.ToDouble(Console.ReadLine()); 


            //Scores

            double totaal = wiskunde + scheikunde + natuurkunde + economie; 
            if (wiskunde > 60) {
                if (scheikunde > 60)
                Console.WriteLine("Je bent geslaagd!");
            }
            if (natuurkunde > 60) {
                Console.WriteLine("Je bent geslaagd!");
            
            }
            if (totaal > 180) {
                Console.WriteLine("Je bent geslaagd!");

            }
             if (wiskunde < 60) {
                if (scheikunde < 60)
                Console.WriteLine("Je bent helaas gezakt!");
            }
            if (natuurkunde < 60) {
                Console.WriteLine("Je bent helaas gezakt!");
            
            }
            if (totaal < 180) {
                Console.WriteLine("Je bent helaas gezakt!");

            }

            

                
                
            

                   
                    
                        
                    
                 
                    
            
        }
    }  

}  





    









