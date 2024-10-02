using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public class Course : ICourse
    {
        public int CourseId;
        public string CourseName;   
        public static int MaxSubjects =8; 
        private List<CourseSubject> subjects = new List<CourseSubject>();
        public List<CourseSubject> Subjects
        {
            get
            {
                return subjects;
            }
        }

        public int TotalDurationInDays { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddSubject(CourseSubject subject)
        {
            if (subjects.Count < MaxSubjects)
            {
                subjects.Add(subject);
            }
            else
            {
                Console.WriteLine("Max Subjects reached");
            }
        }

        public void RemoveSubject(CourseSubject subject)
        {
            subjects.Remove(subject);
        }

        public void AddSubject(List<CourseSubject> subjectName)
        {
            subjects.AddRange(subjectName);
        }
    }
}