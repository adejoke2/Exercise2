using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            //    1. (Game: lottery) Generate a three-digit lottery number. 
            //   The program prompts the user to enter a three-digit number and determines whether the user wins according to the following rules:
            //    1. If the user input matches the lottery number in the exact order, the award is $10,000.
            //    2. If all the digits in the user input match all the digits in the lottery number, the award is $3,000.
            //    3. If one digit in the user input matches a digit in the lottery number, the award is $1,000.
            
          int lotteryDigit1 = 2;
          int lotteryDigit2 = 4;
          int lotteryDigit3 = 6;

           Console.Write("Enter your first digit:");
           int guessDigit1 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Enter your second digit:");
           int guessDigit2 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Enter your second digit:");
           int guessDigit3 = Convert.ToInt32(Console.ReadLine());

            
            if (lotteryDigit1 == guessDigit1 && lotteryDigit2 == guessDigit2 && lotteryDigit3 ==guessDigit3 )
            {
               Console.WriteLine("Exact Match!!! You have a reward of 10,000$ Prize!!!");
            }
            else if(guessDigit2 == lotteryDigit1 && guessDigit1 == lotteryDigit2 && guessDigit3 == lotteryDigit3)
            {
            Console.WriteLine("Matched all numbers!!! You have a 3,000$ Prize!!!"); 
            }
            else if( guessDigit1 == lotteryDigit1 || guessDigit1 == lotteryDigit2 || guessDigit1 == lotteryDigit3 || guessDigit2 == lotteryDigit1 || guessDigit2 == lotteryDigit2   || guessDigit2 == lotteryDigit3 || guessDigit3 == lotteryDigit1   || guessDigit3 == lotteryDigit2  || guessDigit3 == lotteryDigit3)
            {
              Console.WriteLine("Matched one number!!! You have a 1,000$ Prize!!!");
            }
            else
            {
                Console.WriteLine("No Match, Better Luck Next Time!");
            }
   
        }
    }
}
