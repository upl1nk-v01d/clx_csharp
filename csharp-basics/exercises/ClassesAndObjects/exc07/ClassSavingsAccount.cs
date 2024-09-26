class SavingsAccount
{
    private double AnnualInterestRate { get; set; }

    private double Balance { get; set; }

    private double Deposits { get; set; }

    private double Withdrawals { get; set; }

    double startingBalance = 10000;

    public SavingsAccount(double annualInterestRate)
    {
        AnnualInterestRate = annualInterestRate;
        Balance = startingBalance;
    }

    public void AddDeposit(double ammount)
    {
        Balance += ammount;
        Deposits += ammount;
    }
    
    public void Withdraw(double ammount)
    {
        Balance -= ammount;
        Withdrawals += ammount;
    }
    
    public void AddMonthlyInterest(double ammount)
    {
        Balance += ammount * Balance;
    }

    public double GetBalance()
    {
        return Balance;
    }

    public double GetDeposits()
    {
        return Deposits;
    }

    public double GetWithdrawals()
    {
        return Withdrawals;
    }
}
