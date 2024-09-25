using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachineNS
{
    public class VendingMachine : IVendingMachine
    {
        public string Manufacturer { get; set; }

        public bool HasProducts { get; set; }

        public Money Amount { get; set; }

        public Money Balance = new Money(); //Vending machine's money balance

        public Money InsertedCoinsBalance = new Money();

        public Product[] Products { get; set; }

        private List<Product> ProductList = new List<Product>();

        public int ChosenProductIndex;

        public bool CheckCoins(Money coins)
        {
            if (coins.Euros > 0)
            {
                if (coins.Euros == 2 || coins.Euros == 1)
                {
                    Console.WriteLine($"Inserted {coins.Euros} Euros");
                }
                else
                {
                    Console.WriteLine("Please insert 1 or 2 Euro coins!");
                }
            }

            if (coins.Cents > 0)
            {
                if (coins.Cents == 10 || coins.Cents == 20 || coins.Cents == 50)
                {
                    Console.WriteLine($"Inserted {coins.Cents} Eurocents");
                }
                else
                {
                    Console.WriteLine("Please insert 10, 20, or 50 Eurocent coins!");
                    return false;
                }
            }

            return true;
        }

        public Money InsertCoin(Money amount)
        {
            if (CheckCoins(amount))
            {
                this.Balance.Euros += amount.Euros;
                this.Balance.Cents += amount.Cents;

                this.InsertedCoinsBalance.Euros += amount.Euros;
                this.InsertedCoinsBalance.Cents += amount.Cents;

                double balance = this.InsertedCoinsBalance.Euros + this.InsertedCoinsBalance.Cents * 0.01;
                Console.WriteLine($"Balance: {balance} EUR");

                return amount;
            }

            return amount;
        }

        public bool CheckProduct(int index)
        {
            if(ProductList[ChosenProductIndex].Available < 1)
            {
                Console.WriteLine($"Product {ProductList[index].Name} is not available!");
            }
            else
            {
                return true;
            }
            
            return false;
        }

        public Money ReturnMoney()
        {
            int productEuros = ProductList[ChosenProductIndex].Price.Euros;
            int productCents = ProductList[ChosenProductIndex].Price.Cents;

            double insertedSum = this.InsertedCoinsBalance.Euros + this.InsertedCoinsBalance.Cents * 0.01;
            double ProductPrice = productEuros + productCents * 0.01;
            double difference = insertedSum - ProductPrice;

            int returnEuros = Convert.ToInt32(Math.Floor(difference));
            int returnCents = Convert.ToInt32((difference - returnEuros) * 100);

            Money returnSum = new Money { Euros = returnEuros, Cents = returnCents };

            Console.WriteLine($"Returning money: {difference:0.00}");

            this.InsertedCoinsBalance.Euros = 0;
            this.InsertedCoinsBalance.Cents = 0;

            this.ChosenProductIndex = -1;

            return returnSum;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            this.ProductList.Add(new Product { Name = name, Price = price, Available = count });

            int euros = price.Euros;
            double cents = price.Cents * 0.01;
            double _price = euros + cents;

            this.HasProducts = true;

            Console.WriteLine($"Added product: {name} with price {_price:0.00} EUR and quantity {count} pieces");

            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            this.ProductList[productNumber] = new Product { Name = name, Price = price.Value, Available = amount };

            return true;
        }

        public int BuyProduct(int productNumber)
        {
            productNumber -= 1; //converting to index
            
            Money productPrice = ProductList[productNumber].Price;

            int productEuros = ProductList[productNumber].Price.Euros;
            int productCents = ProductList[productNumber].Price.Cents;

            double coinsSum = productEuros + productCents * 0.01;
            double insertedSum = this.InsertedCoinsBalance.Euros + this.InsertedCoinsBalance.Cents * 0.01;

            if (insertedSum == 0)
            {
                Console.WriteLine("Returning back inserted incorrect coins!");
            }
            else if (coinsSum > insertedSum)
            {
                Console.WriteLine("Not enough money inserted to buy this product!");
            }
            else
            {
                this.Balance.Euros += productEuros;
                this.Balance.Cents += productCents;

                this.ChosenProductIndex = productNumber;

                if(this.CheckProduct(productNumber)) //checking product availability
                {
    
                    string productName = this.ProductList[productNumber].Name;
                    int productAvailable = this.ProductList[productNumber].Available - 1;
        
                    this.UpdateProduct(productNumber, productName, productPrice, productAvailable);
    
                    double _price = productEuros + productCents * 0.01;
    
                    Console.WriteLine($"You bought product {productName} with price {_price:0.00} EUR");
        
                    this.ReturnMoney();

                    if(ProductList[ChosenProductIndex].Available < 1)
                    {
                        ProductList.RemoveAt(ChosenProductIndex);
                    }
                }
                else
                {
                    this.ChosenProductIndex = -1;
                }
            }

            if(this.ProductList.Count < 1)
            {
                this.HasProducts = false;
            }

            return productNumber;
        }

        public VendingMachine(string manufacturer, int amountEuros, int amountCents)
        {
            this.Manufacturer = manufacturer;

            this.Balance.Euros = amountEuros;
            this.Balance.Cents = amountCents;

            this.ChosenProductIndex = -1;
        }
    }
}