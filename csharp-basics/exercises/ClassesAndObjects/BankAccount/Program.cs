using System;
using System.Collections.Generic;

namespace BankAccount
{
    class Account
    {
        private string Name { get; set; }

        private double Balance { get; set; }

        public Account(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public string GetAccountName()
        {
            return Name;
        }
    }

    class Program
    {
        private static List<Account> users = new List<Account>(); 

        private static void AddUser(string name, double balance)
        {
            users.Add(new Account(name, balance));
        }

        private static string ShowUserNameAndBalance(string name)
        {
            foreach(var user in users)
            {
                if(user.GetAccountName().ToLower() == name.ToLower())
                {
                    string minus = user.GetBalance() < 0 ? "-" : "";

                    return $"{user.GetAccountName()}, {minus}${Math.Abs(user.GetBalance()):0.00}";
                }
            }
            
            return users.ToString();    
        }

        private static void Main(string[] args)
        {
            AddUser("Benson", 17.25);
            AddUser("Alfred", 18.19);
            AddUser("Bob", -15.11);

            Console.WriteLine(ShowUserNameAndBalance("bob"));
        }
    }
}
