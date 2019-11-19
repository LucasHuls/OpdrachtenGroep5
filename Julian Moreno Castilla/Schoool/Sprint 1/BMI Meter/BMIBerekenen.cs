using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BMI
{
	class Program
	{
		static void Main(string[] args)
		{
            
			Console.Write("Je lengte in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Je gewicht in kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());


            double bmi = weight/(height*height);

            Console.WriteLine("Je BMI is:{0}", Math.Round(bmi, 4));

            Console.ReadLine();
		}
	}
}
