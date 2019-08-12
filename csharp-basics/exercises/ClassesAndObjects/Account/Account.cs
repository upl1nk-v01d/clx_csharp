using System;

namespace Exercise13
{
    public class Account
    {
        private double _balance;
        private string _owner;

        public Account(string owner, double balance) {
            _balance = balance;
            _owner = owner;
        }

        public void Deposit(double amount) {
            _balance += amount;
        }

        public void Withdrawal(double amount) {
            _balance -= amount;
        }
        
        public override string ToString() => _owner + " balance: " + _balance;
    }
}