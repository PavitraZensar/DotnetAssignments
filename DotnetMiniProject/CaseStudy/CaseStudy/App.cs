using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class App
    {

        public static void Scenario1_Student()
        {
            Info i1 = new Info();

            Student stu1 = new Student(101, "Shashru", "08/08/2004");
            Student stu2 = new Student(102, "Ashwini", "09/01/1991");
            Student stu3 = new Student(103, "Manogna", "10/01/1992");
            Student stu4 = new Student(104, "Vijaya", "11/02/1993");
            Student stu5 = new Student(105, "Divya", "12/03/1994");

            i1.display(stu1);
            i1.display(stu2);
            i1.display(stu3);
            i1.display(stu4);
            i1.display(stu5);
        }

        public static void scenario2_Student()
        {
            Info i2 = new Info();

            Student[] student = new Student[5];
            student[0] = new Student(1, "Vasanth", "01/01/2000");
            student[1] = new Student(2, "Vatsav", "02/02/2001");
            student[2] = new Student(3, "Vineetha", "03/03/2002");
            student[3] = new Student(4, "Minni", "04/04/2003");
            student[4] = new Student(5, "Ramya", "05/05/2004");

            for (int i = 0; i < student.Length; i++)
            {
                i2.display(student[i]);
                Console.WriteLine();
            }
        }

        public static void scenario3_Student()
        {
            Student[] stud = new Student[2];
            for (int i = 0; i < stud.Length; i++)
            {
                int id;
                string name, Dob;
                Console.WriteLine("Enter Student ID : ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Student Date of Birth : ");
                Dob = Console.ReadLine();
                Console.WriteLine();
                stud[i] = new Student(id, name, Dob);
            }

            Console.WriteLine();
            Console.WriteLine(" Entered Students details :");
            Info i3 = new Info();

            for (int i = 0; i < stud.Length; i++)
            {
                i3.display(stud[i]);
                Console.WriteLine();
            }
        }


        public static void scenario1_Course()
        {
            Info i2 = new Info();
            Course c1 = new Course(1001, "JAVASCRIPT", 30, 30000);
            Course c2 = new Course(1002, "SQL", 7, 7000);
            Course c3 = new Course(1003, "DOTNET", 45, 45000);
            Course c4 = new Course(1004, "C#", 35, 35000);

            i2.display(c1);
            i2.display(c2);
            i2.display(c3);
            i2.display(c4);

        }

        public static void scenario2_Course()
        {
            Info i2 = new Info();
            Course[] course = new Course[5];
            course[0] = new Course(205, "WEB TECHNOLOGIES", 20, 20000);
            course[1] = new Course(206, "BOOT STRAP", 10, 10000);
            course[2] = new Course(207, "LINUX", 15, 15000);
            course[3] = new Course(208, "HTML", 5, 5000);
            course[4] = new Course(209, "AWS", 14, 14000);

            for (int i = 0; i < course.Length; i++)
            {
                i2.display(course[i]);
                Console.WriteLine();
            }
        }

        public static void scenario3_Course()
        {
            Course[] course = new Course[2];
            for (int i = 0; i < course.Length; i++)
            {
                int id;
                string name;
                float duration;
                float fees;

                Console.WriteLine("Enter Course ID : ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Course Name : ");
                name = Console.ReadLine();

                Console.WriteLine("Enter Course Duration in days : ");
                duration = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter Course Fees : ");
                fees = float.Parse(Console.ReadLine());
                Console.WriteLine();
                course[i] = new Course(id, name, duration, fees);

            }
            Console.WriteLine();
            Console.WriteLine("Entered Course Details :");

            Info i3 = new Info();
            for (int i = 0; i < course.Length; i++)
            {
                i3.display(course[i]);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            /* Console.WriteLine("**************STUDENTS DETAILS*************");
             Console.WriteLine();
             Console.WriteLine("-----------------Scenario 1----------------");
             Console.WriteLine();
             scenario1_Student();
             Console.WriteLine("-----------------Scenario 2----------------");
             Console.WriteLine();
             scenario2_Student();
             Console.WriteLine("-----------------Scenario 3----------------");
             Console.WriteLine();
             scenario3_Student();
             Console.WriteLine("***************COURSE DETAILS*************");
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine("-----------------Scenario 1----------------");
             Console.WriteLine();
             scenario1_Course();
             Console.WriteLine("-----------------Scenario 2----------------");
             Console.WriteLine();
             scenario2_Course();
             Console.WriteLine("-----------------Scenario 3----------------");
             Console.WriteLine();
             scenario3_Course();*/



            AppEngine ae = new AppEngine();

            //Enroll e = new Enroll();
            //ae.introduce();
            //ae.register();                  

            Interface_Details ID = new Interface_Details();
            ID.showFirstScreen();


            //ae.enroll();
            Console.Read();
        }

    }
}
