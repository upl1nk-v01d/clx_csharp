namespace Persons
{
    class Student : Person
    {
        private double GPA { get; set; }

        public Student(string firstName, string lastName, string address, int id, double gpa) 
        : base(firstName, lastName, address, id)
        {
            GPA = gpa;
        }

        public override string Display()
        {
            var (firstName, lastName, address, id) = this.GetData();

            string output = "";

            output += "firstName: " + firstName + ", \n";
            output += "lastName: " + lastName + ", \n";
            output += "address: " + address + ", \n";
            output += "id: " + id.ToString() + ", \n";
            output += "GPA: " + this.GPA.ToString() + "\n";

            return output;
        }
    }
}