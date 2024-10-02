using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public class Staff : Person
    {
        public int WorkingHoursPerWeek { get; set; }
        public int  Id {get; private set;}
        public Staff()
        {
            Console.WriteLine("Staff object created");
            FirstName = "John";
        }

        public Staff(string firstName, string lastName) : base(firstName, lastName)
        {
            firstName = "John";
            lastName = "Doe";
            WorkingHoursPerWeek = 40;
        }
        protected internal void CalculateFees(decimal electiveFees, ref decimal roughFees, out decimal finalFees)
        {
            electiveFees = 1000;
            roughFees = 1000;
            finalFees = 1000;
        }

        /* public void UpdateInfo(string firstName)
        {
            FirstName = firstName;
        } */
        private protected void UpdateInfo(string firstName, string lastName = "")
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}