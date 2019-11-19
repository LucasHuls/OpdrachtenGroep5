using System;

namespace Project_groep_rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        
                   
    {
        //string amount = string.Format("{0:C}");
        double result;
        Console.WriteLine("Hoeveel dollor naar euro?: ");
        double quantity;
        double euro = 0.22D;
        quantity = double.Parse(Console.ReadLine());
        result = quantity * euro;
        Console.WriteLine(("{0:C} Euro"), result);
    }
        
    }
}
