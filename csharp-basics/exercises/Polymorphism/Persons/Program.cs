using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Student student = new Student("Bob", "Walker", "Texas", 1234, 3.75);
            Person employee = new Employee("Gerhard", "Gambler", "Utah", 5432, "Wallmart");

            Console.WriteLine(student.Display());
            Console.WriteLine(employee.Display());
        }
    }
}