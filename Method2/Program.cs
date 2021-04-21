using System;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
			 internal class Lutyoung
			 {
				    Lutyoung input = new Lutyoung()
					Console.Write("Enter a number: ");

			 }
        
		   
		   long number = input.nextLong();

		
		   Console.WriteLine("The approximated square root of " + number + " is: " + sqrt(number));
			
	    }
	
	    public static double sqrt(long n)
		 {
		long lastGuess = 1;	// Initial guess to positive value
		long nextGuess = (lastGuess + n / lastGuess) / 2; 

		// If the difference between nextGuess and lastGuess is less than 0.0001,
		// return nextGuess as the approximated square root of n.
		while (nextGuess - lastGuess > 0.0001)
		 {
			lastGuess = nextGuess;
			nextGuess = (lastGuess + n / lastGuess) / 2;
		}
		lastGuess = nextGuess;
		return nextGuess = (lastGuess + n / lastGuess) / 2;
        }
    }

   
}
