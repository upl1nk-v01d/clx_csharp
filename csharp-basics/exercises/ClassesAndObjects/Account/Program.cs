using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var bartosAccount = new Account("Barto's account", 100.00);
            var bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            /*
            bartosAccount.withdrawal(20);
            Console.WriteLine("Barto's account balance is now: "+bartosAccount.balance());
            bartosSwissAccount.deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: "+bartosSwissAccount.balance());
            */

            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);
        }
    }
}
