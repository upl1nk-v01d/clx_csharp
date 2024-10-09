using System;

namespace VendingMachineNS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);

            vendingMachine.AddProduct("PepsiCola", new Money { Euros = 1, Cents = 20 }, 0);
            vendingMachine.AddProduct("Fanta", new Money { Euros = 1, Cents = 40 }, 6);
            vendingMachine.AddProduct("Sprite", new Money { Euros = 1, Cents = 30 }, 7);

            vendingMachine.InsertCoin(new Money{ Euros = 2, Cents = 0 });

            vendingMachine.BuyProduct(1); //choose rank number not index
            vendingMachine.BuyProduct(2); 

            vendingMachine.InsertCoin(new Money{ Euros = 2, Cents = 20 });
            vendingMachine.InsertCoin(new Money{ Euros = 3, Cents = 0 });
            vendingMachine.InsertCoin(new Money{ Euros = 0, Cents = 30 });

            vendingMachine.BuyProduct(3); 
		}	
    }
}
