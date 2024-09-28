namespace Persons
{
    public class Person
    {
        protected string FirstName { get; set; }

        protected string LastName { get; set; }

        protected string Address { get; set; }

        protected int Id { get; set; }

        public Person(string firstName, string lastName, string address, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Id = id;
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