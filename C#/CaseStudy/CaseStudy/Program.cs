using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }



        public Student(int id, string name, string dob)
        {
            Id = id;
            Name = name;
            DOB = dob;
        }



    }
    public class Course
    {
        public int Id;
        public string Name;
        public int Duration;
        public float Fees;

        public Course(int id, string name, int dura, float fees)
        {
            this.Id = id;
            this.Name = name;
            this.Duration = dura;
            this.Fees = fees;
        }

    }
    public class Info
    {
        public void display(Student student)
        {
            Console.WriteLine($"The student Details is student id {student.Id}, student name {student.Name}, student dob {student.DOB}");



        }



        public void display(Course course)
        {
            Console.WriteLine($"The Course id {course.Id}, Course name {course.Name}, Course duration is {course.Duration}, Course fees is {course.Fees}");
        }
    }
    class App
    {
        Info info = new Info();
        public void Scenario1()
        {
            Student student1 = new Student(36, "Vijaya", "05-5-2000");
            Student student2 = new Student(18, "Vatsav", "23-7-1999");

            info.display(student1);
            info.display(student2);
        }



        public void Scenario2()
        {
            Student[] students = new Student[2];
            students[0] = new Student(12, "Harshitha", "4-12-1999");
            students[1] = new Student(26, "Dharani", "06-06-2000");
            for (int i = 0; i < students.Length; i++)
            {
                info.display(students[i]);

            }
        }
        public void Scenario3()
        {
            Console.WriteLine("Enter the No.of students you want");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[n];
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Enter Student Id,Name and Date of Birth");
                student[i] = new Student(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());

            }
            for (int i = 0; i < student.Length; i++)
            {
                info.display(student[i]);
            }



        }

        public void Courseclass()
        {
            Course course = new Course(24, "Pavitra", 45, 10000.00f);
            info.display(course);
        }
        static void Main(string[] args)
        {
            App app = new App();
            app.Scenario1();
            app.Scenario2();
            app.Scenario3();
            app.Courseclass();
            Console.Read();
        }



    }
}
