using System;
using System.Collections.Generic;

namespace BankAccount
{
    class Account
    {
        public string Name { get; set; }
        private double _realBalance { get; set; }
        public double Balance { get; set; }

        private void AddToBalance(double ammount)
        {
            _realBalance = Balance;
        }

        public Account(string name, double balance)
        {
            Name = name;
            Balance = balance;
            AddToBalance(balance);
        }
    }

    class Program
    {
        private static List<Account> users = new List<Account>(); 

        private static void AddUser(string name, double balance)
        {
            users.Add(new Account(name, balance));
        }

        public static string ShowUserNameAndBalance(string name)
        {
            foreach(var user in users)
            {
                if(user.Name.ToLower() == name.ToLower())
                {
                    string minus = user.Balance < 0 ? "-" : "";

                    return $"{user.Name}, {minus}${Math.Abs(user.Balance):n}";
                }
            }
            
            return users.ToString();    
        }

        public static void Main(string[] args)
        {
            AddUser("Benson", 17.25);
            AddUser("Alfred", 18.19);
            AddUser("Bob", -15.11);

            Console.WriteLine(ShowUserNameAndBalance("bob"));
        }
    }
}
