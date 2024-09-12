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

        }
    }
}
