namespace Persons
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public int Id { get; set; }

        public Person(string firstName, string lastName, string address, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Id = id;
        }

        public virtual (string, string, string, int) GetData()
        {
            return (FirstName, LastName, Address, Id);
        }

        public virtual string Display()
        {
            string output = "";
            
            output += "FirstName: " + this.FirstName + ", \n";
            output += "LastName: " + this.LastName + ", \n";
            output += "Address: " + this.Address + ", \n";
            output += "Id: " + this.Id.ToString() + "\n";

            return output;
        }
    }
}