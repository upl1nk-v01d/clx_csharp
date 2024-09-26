class SavingsTest
{
    static private void Main(string[] args)
    {
        SavingsAccount savingsAccount = new SavingsAccount(1000);

        Console.Clear();
        Console.WriteLine($"How much money is in the account?: {savingsAccount.GetBalance()}");
        Console.WriteLine($"Press any key to continue...");        
        Console.ReadKey(true);

        //Console.Clear();
        Console.WriteLine($"Enter the annual interest rate: ");
        int interestRate = int.Parse(Console.ReadLine()!);

        //Console.Clear();
        Console.WriteLine($"How long has the account been opened?: ");
        int months = int.Parse(Console.ReadLine()!);

        for(int m = 0; m < months; m++)
        {
            Console.WriteLine($"Enter amount deposited for month: {m + 1}: ");
            double deposit = int.Parse(Console.ReadLine()!);
            savingsAccount.AddDeposit(deposit);
            
            Console.WriteLine($"Enter amount withrdaw for month: {m + 1}: ");
            double withdrawnal = int.Parse(Console.ReadLine()!);
            savingsAccount.Withdraw(withdrawnal);
        }

        Console.WriteLine($"Total deposited: ${savingsAccount.GetDeposits():n}");
        Console.WriteLine($"Total withdrawn: ${savingsAccount.GetWithdrawals():n}");
        Console.WriteLine($"Interest earned: ${savingsAccount.GetWithdrawals():n}");
        Console.WriteLine($"Ending balance: ${savingsAccount.GetBalance():n}");

        /*
        Total deposited: $7,830.00
        Total withdrawn: $5,777.00
        Interest earned: $29,977.72
        Ending balance: $42,030.72
        */
    }
}
