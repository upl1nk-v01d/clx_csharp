using System;

namespace Account;

class Program
{
    public static void Transfer(Account from, Account to, double howMuch)
    {
        from.Withdrawal(howMuch);
        to.Deposit(howMuch);
    }

    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Let's create some bank accounts!");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);
        
        Console.Clear();
        Account MattsAccount = new Account("Matt's account", 1000);
        Account SergeysAccount = new Account("Sergey's Account", 500);
        Account MyAccount = new Account("My Account", 0);
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);
        
        Console.Clear();
        Console.WriteLine("Let's check user's account balances!");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);

        Console.Clear();
        Console.WriteLine($"{MattsAccount.GetAccountName()} currently has {MattsAccount.Balance()}");
        Console.WriteLine($"{SergeysAccount.GetAccountName()} currently has {SergeysAccount.Balance()}");
        Console.WriteLine($"{MyAccount.GetAccountName()} currently has {MyAccount.Balance()}");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);
        
        Console.Clear();
        Console.WriteLine("Let's make some money transfers!");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);

        Console.Clear();
        Transfer(MattsAccount, MyAccount, 50);
        Transfer(MyAccount, SergeysAccount, 25);
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);

        Console.Clear();
        Console.WriteLine("Let's check again user's account balance!");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);

        Console.Clear();
        Console.WriteLine($"{MattsAccount.GetAccountName()} currently has {MattsAccount.Balance()}");
        Console.WriteLine($"{SergeysAccount.GetAccountName()} currently has {SergeysAccount.Balance()}");
        Console.WriteLine($"{MyAccount.GetAccountName()} currently has {MyAccount.Balance()}");
        Console.WriteLine("\nPress any key to quit program...");
        Console.ReadKey(true);
        Console.Clear();

    }
}