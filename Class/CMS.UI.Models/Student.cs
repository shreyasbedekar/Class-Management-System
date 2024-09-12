namespace CMS.UI.Models;

public class Student
{
        public string FirstName = default;
        public string LastName = string.Empty;
        public int StudentId = 10;
        //public const int MaxEnrolledCourses = 3;
        public readonly int MaxEnrolledCourses = 3;
        public static int MaxBooksAllowed =5;
        public Student()
        {
                int TotalCourses = 0;
                MaxEnrolledCourses =TotalCourses;
        }
}
