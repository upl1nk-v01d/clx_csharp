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
            string output = "";

            output += "firstName: " + FirstName + ", \n";
            output += "lastName: " + LastName + ", \n";
            output += "address: " + Address + ", \n";
            output += "id: " + Id.ToString() + ", \n";
            output += "GPA: " + GPA.ToString() + "\n";

            return output;
        }
    }
}