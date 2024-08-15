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

            int convertedA = Convert.ToInt32(a);
            int convertedD = Convert.ToInt32(d);
            int convertedE = Convert.ToInt32(e);

            //fixme - should be 15 :|
            int sum =  convertedA + b + c + convertedD + convertedE;
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
            decimal convertedA = Convert.ToDecimal(a);
            decimal convertedD = Convert.ToDecimal(d);
            decimal convertedE = Convert.ToDecimal(e);

            decimal sum = convertedA + b + c + convertedD + convertedE;
            Console.WriteLine(sum);
        }
    }
}
