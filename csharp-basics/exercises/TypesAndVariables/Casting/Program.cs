using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Console.ReadKey();
        }

        static void First()
        {
            // can't change variable types.
            string a = "1";
            int b = 2;
            int c = 3;
            double d = 4;
            float e = 5;

            int convertedA = Convert.ToInt32(a); //convertion of variable 'a' to integer
            int convertedD = Convert.ToInt32(d); //convertion of variable 'd' to integer
            int convertedE = Convert.ToInt32(e); //convertion of variable 'e' to integer

            //fixme - should be 15 :|
            int sum =  convertedA + b + c + convertedD + convertedE;  // adding integer variables
            Console.WriteLine(sum);
        }

        static void Second()
        {
            // can't change variable types.
            string a = "1";
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;

            //fixme - should be 15.5 :| 
            decimal convertedA = Convert.ToDecimal(a); //convertion of variable 'a' to decimal
            decimal convertedD = Convert.ToDecimal(d); //convertion of variable 'd' to decimal
            decimal convertedE = Convert.ToDecimal(e); //convertion of variable 'e' to decimal

            decimal sum = convertedA + b + c + convertedD + convertedE; // adding decimal variables
            Console.WriteLine(sum);
        }
    }
}
