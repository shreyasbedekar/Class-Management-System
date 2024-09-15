using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using CMS.UI.Models;

namespace CMS.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Staff staff = new Staff();
            Course computerScience = new Course();

            student.FirstName = "John";
            Console.WriteLine(student.FirstName);

            Student student2 = new Student()
            {
                FirstName = "Jane",
                LastName = "Doe",
                StudentId = 1234
            };

            //readonly variable
            //student2.MaxEnrolledCourses = 5;

            //static variable
            Student.MaxBooksAllowed = 10;
            Console.WriteLine(Student.MaxBooksAllowed); 

            //Value and Reference Types
            Console.WriteLine("Value and Reference Types");
            int x = 10;
            Console.WriteLine(x);
            int b=x;
            b = 20;
            Console.WriteLine(x);

            student.FirstName = "Jane";
            Console.WriteLine(student.FirstName);
            student2 = student;
            student2.FirstName = "Mary";
            Console.WriteLine(student.FirstName);

            //Acess Modifiers
            //staff.FirstName = "John";

            computerScience.CourseId = 1;
            computerScience.CourseName = "Computer Science";
            Console.WriteLine(computerScience.CourseId);
            Console.WriteLine(computerScience.CourseName);
        }
    }
}
