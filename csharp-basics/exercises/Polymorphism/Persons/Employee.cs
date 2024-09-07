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
            string output = "";
            
            output += "firstName: " + FirstName + ", \n";
            output += "lastName: " + LastName + ", \n";
            output += "address: " + Address + ", \n";
            output += "id: " + Id.ToString() + ",\n";
            output += "jobTitle: " + JobTitle + "\n";

            return output;
        }
    }
}