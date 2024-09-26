using System;

namespace Account
{
    class Account
    {
        public string _name { get; set; }
        private double _balance { get; set; }

        public Account(string name, double balance)
        {
            _name = name;
            _balance = balance;
            this.WelcomeMessage();
        }

        public string GetAccountName()
        {
            return _name;
        }

        private void WelcomeMessage()
        {
            Console.WriteLine($"Account with name {this._name} has been created!");
        }

        public void Withdrawal(double amount)
        {
            this._balance -= amount;
            Console.WriteLine($"The amount {amount} from {this._name} has been withdrawed!");
        }

        public void Deposit(double amount)
        {
            this._balance += amount;
            Console.WriteLine($"The amount {amount} from {this._name} has been deposited!");
        }

        public double Balance()
        {
            return this._balance;
        }
    }
}
