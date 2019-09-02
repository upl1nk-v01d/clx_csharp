namespace Account
{
    class Account
    {
        private string _name;
        private double _money;

        public Account(string v1, double v2)
        {
            _name = v1;
            _money = v2;
        }

        public double withdrawal(double i)
        {
            _money -= i;
            return i;
        }

        public void deposit(double i)
        {
            _money += i;
        }

        public double balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
