using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    public class Student
    {
        private int ID;
        public int StudId
        {
            get { return ID; }
            set { ID = value; }

        }

        private string Name;
        public string StudName
        {
            get { return Name; }
            set { Name = value; }

        }
        public string DOB;


        //public string name,Date;         

        public Student(int id, string name, string dob)
        {
            ID = id;
            Name = name;
            DOB = dob;

        }
    }
    public class Course
    {
        private int ID;
        public int CourseID
        {
            get { return ID; }
            set { ID = value; }
        }

        private string Name;
        public string CourseName
        {
            get { return Name; }
            set { Name = value; }

        }

        public float Course_Duration;
        public float fees;

        public Course(int id, string Course_Name, float duration, float CourseFees)
        {
            ID = id;
            Name = Course_Name;
            Course_Duration = duration;
            fees = CourseFees;
        }

    }

    class Info
    {

        public void display(Student student)
        {
            //Code here to display the details of given student

            Console.WriteLine($"The Student details are Student Name is:  {student.StudName} \n  Student ID is :  {student.StudId } \n and DateOfBirth is: { student.DOB}");

            Console.WriteLine();
        }

        public void display(Course course)
        {
            Console.WriteLine($"The Course ID is:  {course.CourseID} \n  Course Name is :  {course.CourseName } \n Course Duration is: { course.Course_Duration} in days \n and the Course Fees is: {course.fees}");

            Console.WriteLine();
        }
    }
}
