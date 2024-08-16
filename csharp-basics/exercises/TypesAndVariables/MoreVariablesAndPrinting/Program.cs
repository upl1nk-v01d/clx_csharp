using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Zed A. Shaw";
            int age = 35;
            int h_inches = 74;  // height of inches
            int w_pounds = 180; // weight of pounds (lbs)
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";
            decimal k_cms = 2.54m; //coefficient of centimeters
            decimal k_kgs = 0.453592m; //coefficient of kilograms

            decimal h_cms = Convert.ToDecimal(h_inches) * k_cms; //convertion to centimeters
            decimal w_kgs = Convert.ToDecimal(w_pounds) * k_kgs; //convertion to kilograms

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + String.Format("{0:0.0#}",h_cms) + " centimeters tall.");
            Console.WriteLine("He's " + String.Format("{0:0.0#}",w_kgs) + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " 
                + String.Format("{0:0.0#}",h_cms) + ", and " 
                + String.Format("{0:0.0#}",w_kgs)
                + " I get " + String.Format("{0:0.0#}",age + h_cms + w_kgs) 
                + ".");

            Console.ReadKey();
        }
    }
}