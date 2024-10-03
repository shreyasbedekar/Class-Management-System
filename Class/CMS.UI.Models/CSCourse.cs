using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public class CSCourse : Course
    {
        public override void AddSubject(CourseSubject subject)
        {
            Console.WriteLine("Calling CSCourse.AddSubject(CourseSubject)");
            base.AddSubject(subject);
        }
    }
}