namespace Persons
{
    class Employee : Person
    {
        private string JobTitle { get; set; }

        public Employee(string firstName, string lastName, string address, int id, string jobTitle) 
        : base(firstName, lastName, address, id)
        {
            JobTitle = jobTitle;
        }

        public override string Display()
        {
            var (firstName, lastName, address, id) = this.GetData();

            string output = "";
            
            output += "firstName: " + firstName + ", \n";
            output += "lastName: " + lastName + ", \n";
            output += "address: " + address + ", \n";
            output += "id: " + id.ToString() + ",\n";
            output += "jobTitle: " + this.JobTitle + "\n";

            return output;
        }
    }
}