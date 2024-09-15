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
                Console.WriteLine("Student object created");
                int TotalCourses = 0;
                MaxEnrolledCourses =TotalCourses;
        }
        public Student(int studentId,string firstName, string lastName)
        {
                Console.WriteLine("Calling Student.Student(int studentId,string firstName, string lastName)");
                FirstName = firstName;
                LastName = lastName;
                StudentId = studentId;
        }
        ~Student()
        {
                Console.WriteLine("Student object destroyed");
        }
        public int GetId()
        {
                return StudentId;
        }
        public string GetFullName()
        {
                return FirstName + " " + LastName;
        }
}
