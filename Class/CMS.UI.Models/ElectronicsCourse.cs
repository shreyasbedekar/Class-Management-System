using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public class ElectronicsCourse : Course
    {
        public override void AddSubject(CourseSubject subject)
        {
            Console.WriteLine("Calling ElectronicsCourse.AddSubject(CourseSubject)");
            base.AddSubject(subject);
        }

        public override void RemoveSubject(CourseSubject subject)
        {
            Console.WriteLine("Calling ElectronicsCourse.RemoveSubject(CourseSubject)");
            base.RemoveSubject(subject);
        }
    }
}