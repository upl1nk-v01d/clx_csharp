using System;

namespace Exercise8
{
    internal class Program
    {
        //there was error with finding project file, just created new c# console app.
        static void Main(string[] args) 
        {
            Console.WriteLine("ievadi minutes");
            var minutes = int.Parse(Console.ReadLine());

            decimal minutesInYear = 365 * 24 * 60;
            decimal miutesInDay = 24 * 60;

            decimal years = minutes / minutesInYear;
            decimal minutesToDays = minutes % minutesInYear;
            decimal days = minutesToDays / miutesInDay;
            
            //just needed a little text formatting
            Console.WriteLine($"it's {years:0.000} years and {days:0.000} days");

            Console.ReadKey();
        }
    }
}
