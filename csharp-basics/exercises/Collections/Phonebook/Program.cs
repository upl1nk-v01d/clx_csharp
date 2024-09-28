using System;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            PhoneDirectory phoneDirectory = new PhoneDirectory();

            phoneDirectory.PutNumber("Alfred", "+372 1234 8765");
            phoneDirectory.PutNumber("Baron", "+212 3 87 16 33 90");
            phoneDirectory.PutNumber("Max Payne", "+98 21 4428 8673");

            var number = phoneDirectory.GetNumber("Alfred");
            var dataCount = phoneDirectory.GetDataCount();

            Console.WriteLine("Alfred's phone number: " + number);
            Console.WriteLine("dataCount: " + dataCount);
        }
    }
}
