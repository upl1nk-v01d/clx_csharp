using System;

namespace Firm
{
    public abstract class StaffMember
    {
        protected string _name;
        protected string _address;
        protected string _phone;
        protected double _hourlyPayRate;

        //-----------------------------------------------------------------
        // Sets up a staff member using the specified information.
        //-----------------------------------------------------------------
        protected StaffMember(string name, string address, string phone, string socialSecurityNumber) 
        {
            _name = name;
            _address = address;
            _phone = phone;
        }

        public StaffMember(string name, string address, string phone, string socialSecurityNumber, double hourlyPayRate) : this(name, address, phone, socialSecurityNumber)
        {
            _hourlyPayRate = hourlyPayRate;
        }

        protected StaffMember(string Name, string Address, string Phone)
        {
            _name = Name;
            _address = Address;
            _phone = Phone;
        }

        protected StaffMember(string Name, string Address) //constructor for subclass Volunteer
        {
            _name = Name;
            _address = Address;
        }


        //-----------------------------------------------------------------
        // Returns a string including the basic employee information.
        //-----------------------------------------------------------------
        public override string ToString() 
        {
            var result = "Name: " + _name + "\n";
            result += "Address: " + _address + "\n";
            result += "Phone: " + _phone;
            return result;
        }

        //-----------------------------------------------------------------
        // Derived classes must define the pay method for each type of
        // employee.
        //-----------------------------------------------------------------
        public abstract double Pay();

        public virtual void AddSales(int sales)
        {
        }

        public string GetName()
        {
            return _name;
        }
    }
}