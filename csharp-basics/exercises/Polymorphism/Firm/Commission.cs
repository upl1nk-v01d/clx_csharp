using System;

namespace Firm
{
    public class Commission : StaffMember
    {
        protected double _commissionRate { get; set; }
        protected double _totalSales { get; set; }
        protected double _hours { get; set; }

        public Commission(string name, string address, string phoneNumber, 
            string socialSecurityNumber, double hourlyPayRate, double commissionRate, 
            double hours, double sales)
            : base(name, address, phoneNumber, socialSecurityNumber)
        {
            _hourlyPayRate = hourlyPayRate;
            _commissionRate = commissionRate * 0.01;
            _hours = hours;
            _totalSales = sales;
        }

        public override void AddSales(int sales)
        {
            _totalSales += sales;
        }

        public override string ToString() 
        {
            var result = base.ToString();
            result += "\nTotal Sales: $" + _totalSales + "\n";
            
            return result;
        }

        public override double Pay()
        {
            var payment = _hourlyPayRate + (_totalSales * _commissionRate);
            return payment;
        }
    }
}