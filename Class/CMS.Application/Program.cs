﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using CMS.UI.Display;
using CMS.UI.Models;


namespace CMS.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
           // Staff staff = new Staff();
           // Course computerScience = new Course();

            //student.FirstName = "John";
            //Console.WriteLine(student.FirstName);

            /* Student student2 = new Student()
            {
                FirstName = "Jane",
                LastName = "Doe",
                StudentId = 1234
            }; */

            //readonly variable
            //student2.MaxEnrolledCourses = 5;

            //static variable
            //Student.MaxBooksAllowed = 10;
            //Console.WriteLine(Student.MaxBooksAllowed); 

            //Value and Reference Types
            //Console.WriteLine("Value and Reference Types");
            //int x = 10;
            //Console.WriteLine(x);
            //int b=x;
            //b = 20;
            //Console.WriteLine(x);

            //student.FirstName = "Jane";
            //Console.WriteLine(student.FirstName);
            //student2 = student;
            //student2.FirstName = "Mary";
            //Console.WriteLine(student.FirstName);

            //Acess Modifiers
            //staff.FirstName = "John";

           // computerScience.CourseId = 1;
            //computerScience.CourseName = "Computer Science";
            //Console.WriteLine(computerScience.CourseId);
            //Console.WriteLine(computerScience.CourseName);

             /* Student student3 = new Student()
            {
                FirstName = "Jane",
                LastName = "Doe",
                StudentId = 12345
            };
            Console.WriteLine(student3.GetId());
            Console.WriteLine(student3.GetFullName()); */

            //Constructor & Destructor
            //Student student4 = new Student();
            //Student student5 = new Student(123, "Jane", "Doe");

            //Properties
           /*  Staff staff2 = new Staff();
            //String name = staff2.FirstName;
            //name = staff2.LastName;

            //Types of passing parameters
            decimal electiveFees = 500;
            decimal roughFees = 500;
            decimal finalFees = 500;
            Console.WriteLine(electiveFees);
            Console.WriteLine(roughFees);
            Console.WriteLine(finalFees);

            staff.CalculateFees(electiveFees, ref roughFees, out finalFees);
            Console.WriteLine("After calling CalculateFees method");
            Console.WriteLine(electiveFees);
            Console.WriteLine(roughFees);
            Console.WriteLine(finalFees);

            //Method Overloading
            staff.UpdateInfo("Jane");
            staff.UpdateInfo("Jane", "Doe");

            //Static class
            Display.Show("Hello World"); */

            //ICourse csCourse = new CSCourse();
            //ICourse eleCourse = new ElectronicsCourse();

            //Console.WriteLine(csCourse.GetTotalElectives());

            //ICourse.DefaultElectives = 10;

            //Interface
            //IStudent student = new Student();
            //student.FirstName = "Jane";
            //student.LastName = "Doe";
            //Console.WriteLine(student.GetFullName());

            //Console.WriteLine(IStudent.WhoAmI());

            //Inheritance
            /* Student student = new Student();
            student.GetFullName();
            List<string> hobbies = student.Hobbies;

            Student student2 = new Student(123, "Jane", "Doe");
            Console.WriteLine(student2.GetFullName());

            Person person = new Student(100, "John", "Doe");
            Console.WriteLine(person.GetFullName());

            student = person as Student;
            if( student != null)
            {
                List<string> hobbies2 = student.Hobbies;
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

            if(person is Student)
            {
                student = (Student)person;
                List<string> hobbies2 = student.Hobbies;
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

            Staff staff = new Staff("Mary", "Smith");
            person = staff;

            if(person is Staff)
            {
                staff = (Staff)person;
                staff.WorkingHoursPerWeek = 40;
                Console.WriteLine(staff.WorkingHoursPerWeek);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            } */

            //Polymorphism
            Course course = new Course();
            course.AddSubject(new CourseSubject(30, "Maths"));

            ElectronicsCourse electronicsCourse = new ElectronicsCourse();
            electronicsCourse.AddSubject(new CourseSubject(401, "Basics of Electrical Science"));

            electronicsCourse.RemoveSubject(new CourseSubject(401, "Basics of Electrical Science"));
        }
    }
}
