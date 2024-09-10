using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        public string Manufacturer { get; set; }

        public bool HasProducts { get; set; }

        public Money Amount { get; set; }
        public double Balance { get; set; }

        public Product[] Products { get; set; }

        public List<Product> _products = new List<Product>();

        public Money ConvertToMoney(int euros, int cents)
        {
            Money m = new Money();
            m.Euros = euros;
            m.Cents = cents;

            return m;
        }
        
        public Money InsertCoin(Money amount)
        {
            Balance += amount.Euros;

            return amount;
        }

        public Money ReturnMoney()
        {
            return Amount;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            Product product = new Product();

            product.Available = count;
            product.Price = price; 
            product.Name = name;

            _products.Add(product);

            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            return false;
        }
        
        public VendingMachine(string manufacturer, int amountEuros, int amountCents)
        {
            Manufacturer = manufacturer;

            Money Amount = new Money();

            Amount.Euros = amountEuros;
            Amount.Cents = amountCents;
        }
    }
}
