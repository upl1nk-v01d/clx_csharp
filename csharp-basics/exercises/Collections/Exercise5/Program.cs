using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise5
{
    class Program
    {
        static int SquareDigits(int passedNumber)
        {
            int squared = 0;

            List<int> squaredNumbers = new List<int>();
            int length = passedNumber.ToString().ToCharArray().ToList().Count();

            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(passedNumber);

                while (passedNumber != 0)
                {
                    Console.WriteLine("passedNumber: " + passedNumber);
                    int digit = passedNumber % 10;
                    Console.WriteLine("digit: " + digit);
                    squared += digit * digit;
                    Console.WriteLine("squared: " + squared);
                    passedNumber /= 10;
                    Console.WriteLine("passedNumber: " + passedNumber + "\n");
                }

                squaredNumbers.Add(squared);

                passedNumber = squared;
                squared = 0;
            }
            
            return squared;
        }
        
        static bool IsHappyNumber(int number)
        {
            int happyNumber = SquareDigits(number);

            if (happyNumber == 1)
            {
                return true;
            }

            return false;
        }
        

        private static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("\n\nPlease enter a number to see if it is happy: ");
            
            int number = Convert.ToInt32(Console.ReadLine());

            string happy = IsHappyNumber(number) == true ? "" : "not";

            Console.WriteLine($"The number {number} is {happy} happy number!");            
        }
    }
}