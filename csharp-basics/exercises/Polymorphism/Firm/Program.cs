using System;

namespace Firm
{
    class Program
    {
        //-----------------------------------------------------------------
        // Creates a staff of employees for a firm and pays them.
        //-----------------------------------------------------------------
        private static void Main(string[] args)
        {
            Console.Clear();
            
            var personnel = new Staff();
            personnel.Payday();
        }
    }
}