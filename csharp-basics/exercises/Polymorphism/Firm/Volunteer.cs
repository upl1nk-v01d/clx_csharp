namespace Firm
{
    public class Volunteer : StaffMember
    {
        private string _socialSecurityNumber;
        
        public Volunteer(string vName, string vAddress, string vSocSecNumber) 
        : base(vName, vAddress)
        {
            _name = vName;
            _address = vAddress;
            _socialSecurityNumber = vSocSecNumber;
        }

        public override string ToString() 
        {
            var result = base.ToString();
            result += "\nSocial Security Number: " + _socialSecurityNumber;

            return result;
        }
    
        public override double Pay()
        {
            return 0.0;
        }
    }
}