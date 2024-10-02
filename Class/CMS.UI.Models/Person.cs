using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("Person object created");
        }

        public Person(string firstName, string lastName)
        {
            Console.WriteLine("Person object calling Person.Person(string, string)");
            FirstName = firstName;
            LastName = lastName;
        }
        protected internal string FirstName { get ; set; }
        public string LastName { get ; set; }
        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}