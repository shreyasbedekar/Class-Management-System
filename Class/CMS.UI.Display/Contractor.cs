using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.UI.Models;

namespace CMS.UI.Display
{
    public class Contractor : Person 
    {
        public string GetFirstName()
        {
            return FirstName;
        }
    }
}