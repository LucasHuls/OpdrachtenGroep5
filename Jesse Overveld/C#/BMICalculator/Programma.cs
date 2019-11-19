using System;
					
public class Program
{
	public static void Main()
	{	/*Variabelen maken */ 
		int Lengte;
		int Gewicht;
		int BMI;
		
		/*Gebruikers input voor de variabelen */
		Console.WriteLine("Vul je lengte in cm in: ");
		Lengte = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Vul je gewicht in kg in: ");
		Gewicht = Convert.ToInt32(Console.ReadLine());

		
		BMI = Convert.ToInt32(Gewicht / ( (Lengte / 100.0 ) * ( Lengte / 100.0 ) ));
		
		/*Overgewicht, ondergewicht of een gezond gewicht, if statements */
	if (BMI >= 18 && BMI <= 24 )
		{
			Console.WriteLine("Je BMI is {0}. Je hebt een gezond gewicht!",BMI);	
		}	
		
	if (BMI < 18)
		{	
			Console.WriteLine("Je BMI is {0}. Je hebt ondergewicht!",BMI);
		}
		
	if (BMI > 24)
		{		
			Console.WriteLine("Je BMI is {0}. Je hebt overgewicht",BMI);	
		}		
	}
}