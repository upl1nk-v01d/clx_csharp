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

            while(passedNumber > 1)
            {
                if(passedNumber == 4)
                {
                    return squared;
                }

                squared = 0;

                while (passedNumber != 0)
                {
                    int digit = passedNumber % 10;
                    squared += digit * digit;
                    passedNumber /= 10;
                }

                squaredNumbers.Add(squared);

                passedNumber = squared;
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

            string happy = IsHappyNumber(number) == true ? "is" : "is not";

            Console.WriteLine($"The number {number} {happy} happy number!");            
        }
    }
}