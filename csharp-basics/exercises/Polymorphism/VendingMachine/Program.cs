using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cant change any of given code
            //Valid money for Vending machine 0.10, 0.20, 0.50, 1.00, 2.00 coins.
            Console.Clear();

            VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);

            vendingMachine.AddProduct("CocaCola", vendingMachine.ConvertToMoney(1500, 50), 5);
            vendingMachine.InsertCoin(vendingMachine.ConvertToMoney(2, 0));

            Console.WriteLine(vendingMachine.Manufacturer);

        }
    }
}
