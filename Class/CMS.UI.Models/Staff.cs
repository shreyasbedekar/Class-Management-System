using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public class Staff
    {
        private string firstName;
        public string FirstName{
            get{
                return FirstName;
            }
            set{
                firstName = value;
            }
        }
        //ublic string LastName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public int  Id {get; private set;}
        public Staff()
        {
            Console.WriteLine("Staff object created");
            FirstName = "John";
        }

        public void CalculateFees(decimal electiveFees, ref decimal roughFees, out decimal finalFees)
        {
            electiveFees = 1000;
            roughFees = 1000;
            finalFees = 1000;
        }

        /* public void UpdateInfo(string firstName)
        {
            FirstName = firstName;
        } */
        public void UpdateInfo(string firstName, string lastName = "")
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}