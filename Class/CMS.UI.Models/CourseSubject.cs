using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public class CourseSubject
    {
        public int Id;
        public string SubjectName;

        public CourseSubject(int id, string subjectName)
        {
            this.Id = id;
            this.SubjectName = subjectName;
        }
    }
}