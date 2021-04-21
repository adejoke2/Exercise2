using System;

namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to reverse:");
            int integer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Reverse of number is " + Reverse(integer));
            Console.WriteLine(isPalindrome(integer));
        }
        private static int Reverse(int number)
        {
            {
                int reversedNumber = 0;

                while (number > 0)
                {
                    reversedNumber = reversedNumber * 10 + number % 10;
                    number = number / 10;
                }
                return reversedNumber;
            }
        }

        public static bool isPalindrome(int num)
        {

            return (num == Reverse(num));
        }
    }
}
