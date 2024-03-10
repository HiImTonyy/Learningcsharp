using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class Person
    {
        public Person()
        {

        }

        public Person(string firstName, string lastname, DateOnly dob)
        {
            FirstName = firstName;
            LastName = lastname;
            DateofBirth = dob;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateofBirth { get; set; }

        public void WriteFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
            Console.ReadLine();
        }

    }
}