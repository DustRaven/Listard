using System;
using System.IO;

namespace PersonNoOO
{
    public class Person
    {
        public string FirstName;
        public string PhoneNumber;
        public string LastName;
        private int alter;

        public Person(string firstName, string lastName, string phoneNumber = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
        }

        public Person(StreamReader reader)
        {
            string[] parts = reader.ReadLine().Split(';');
            this.FirstName = parts[0];
            this.LastName = parts[1];
            this.PhoneNumber = parts[2];
        }

        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Vorname: " + FirstName);
            Console.WriteLine("Nachname: " + LastName);
            Console.WriteLine("Telefon: " + PhoneNumber);
        }

        public void Store(StreamWriter writer)
        {
            writer.WriteLine($"{FirstName};{LastName};{PhoneNumber}");
        }
    }
}
