using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public class ElectronicsCourse : ICourse
    {
        void ICourse.AddSubject(CourseSubject subject)
        {
            throw new NotImplementedException();
        }

        void ICourse.AddSubject(List<CourseSubject> subjectName)
        {
            throw new NotImplementedException();
        }

        void ICourse.RemoveSubject(CourseSubject subject)
        {
            throw new NotImplementedException();
        }
    }
}