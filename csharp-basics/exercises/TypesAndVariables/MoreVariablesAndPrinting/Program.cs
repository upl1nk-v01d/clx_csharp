using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Zed A. Shaw";
            int age = 35;
            int heightInches = 74;  // height of inches
            int weightPounds = 180; // weight of pounds (lbs)
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";
            decimal coefCentimeters = 2.54m; //coefficient of centimeters
            decimal coefKilograms = 0.453592m; //coefficient of kilograms

            //convertion to centimeters
            decimal heightCentimeters = Convert.ToDecimal(heightInches) * coefCentimeters; 

            //convertion to kilograms
            decimal weightKilograms = Convert.ToDecimal(weightPounds) * coefKilograms; 

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + String.Format("{0:0.0#}",heightCentimeters) + " centimeters tall.");
            Console.WriteLine("He's " + String.Format("{0:0.0#}",weightKilograms) + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " 
                + String.Format("{0:0.0#}",coefCentimeters) + ", and " 
                + String.Format("{0:0.0#}",weightKilograms)
                + " I get " + String.Format("{0:0.0#}",age + heightCentimeters + weightKilograms) 
                + ".");

            Console.ReadKey();
        }
    }
}