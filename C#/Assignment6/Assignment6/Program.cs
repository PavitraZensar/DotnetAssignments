using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    //1Q
     interface IStudent
     {
         void DisplayDetails(int Id, string Name);
     }
     class Resident : IStudent
     {
         public void DisplayDetails(int Id, string Name)
         {
             Console.WriteLine("Student id is :{0}", Id);
             Console.WriteLine("Name of the Student is :{0}", Name);
         }
     }
     class DayScholar : IStudent
     {
         public void DisplayDetails(int Id, string Name)
         {
             Console.WriteLine("Student id is :{0}", Id);
             Console.WriteLine("Name of the Student is :{0}", Name);
         }
     }
     class InterfaceEg
     {
         static void Main()
         {

             IStudent obj1 = new Resident();
             obj1.DisplayDetails(100, "Rama");

             IStudent obj = new DayScholar();
             obj.DisplayDetails(101, "Sita");


             Console.ReadLine();
         }
     }

    //3Q
       internal class Program
       {
           public class Employee
           {
               public int emp_id;
               public string F_name;
               public string L_name;
               public string title;
               public string dob;
               public DateTime doj;
               public string city;
               public Employee(int emp_id, string F_name, String L_name, string title, string dob, DateTime doj, string city)
               {
                   this.emp_id = emp_id;
                   this.F_name = F_name;
                   this.L_name = L_name;
                   this.title = title;
                   this.dob = dob;
                   this.doj = doj;
                   this.city = city;
               }

           }
           static void Main(string[] args)
           {
               List<Employee> emplist = new List<Employee>();
               emplist.Add(new Employee(1001, "Malcolm", "Daruwalla", "Manager", "16/11/1984", DateTime.Parse("8/6/2011"), "Mumbai"));
               emplist.Add(new Employee(1002, "Asdin", " Dhalla", "AsstManager", "20/08/1984", DateTime.Parse("7/7/2012"), "Mumbai"));
               emplist.Add(new Employee(1003, "Madhavi ", "Oza", "Consultant", "14/11/1987", DateTime.Parse("12/4/2015"), "Pune"));
               emplist.Add(new Employee(1004, "Saba", "Shaikh", "SE", "3/6/1990", DateTime.Parse("2/2/2016"), "Pune"));
               emplist.Add(new Employee(1005, "Nazia", "Shaikh", "SE", "8/3/1991", DateTime.Parse("2/2/2016"), "Mumbai"));
               emplist.Add(new Employee(1006, "Amit", "Pathak", "Consultant", "7/11/1989", DateTime.Parse("8/8/2014"), "Chennai"));
               emplist.Add(new Employee(1007, "Vijay", "Natrajan", "Consultant ", "2/12/1989", DateTime.Parse("1/6/2015"), "Mumbai"));
               emplist.Add(new Employee(1008, "Rahul", "Dubey", "Associate", "11/11/1993", DateTime.Parse("6/11/2014"), "Chennai"));
               emplist.Add(new Employee(1009, "Suresh", "Mistry", "Associate", "12/8/1992", DateTime.Parse("3/12/2014"), "Chennai"));
               emplist.Add(new Employee(1010, "Sumit", "Shah", "Manager", "12/4/1991", DateTime.Parse("2/1/2016"), "Pune"));

               Console.WriteLine("\nAll the employee details");
               var Query = from Employee in emplist select Employee;
               foreach (var item4 in Query)
               {
                   Console.WriteLine(item4.emp_id + " " + item4.F_name + " " + item4.L_name + " " + item4.title + " " + item4.doj + " " + item4.dob + " " + item4.city + " ");
               }

               Console.WriteLine("\nThe Employees whose name starts with S are");
               var query = from Employee in emplist
                           where Employee.L_name.StartsWith("S")
                           select Employee.L_name;
               foreach (var item in query)
               {
                   Console.WriteLine(item);
               }

               Console.WriteLine("\nThe employee firstname whose title is AsstManager is");
               var query1 = from Employee in emplist
                            where Employee.title == "AsstManager"
                            select Employee.F_name;
               foreach (var item1 in query1)
               {
                   Console.WriteLine(item1);
               }

               Console.WriteLine("\nThe employee firstname whose location is not Mumbai ");
               var query2 = from Employee in emplist
                            where Employee.city != "Mumbai"
                            select Employee.F_name;
               foreach (var item2 in query2)
               {
                   Console.WriteLine(item2);
               }

               Console.WriteLine("\nThe employee first name whose joining date is lessthan 1/1/2015");
               var query3 = from Employee in emplist
                            where Employee.doj < DateTime.Parse("1/1/2015")
                            select Employee.F_name;
               foreach (var item3 in query3)
               {
                   Console.WriteLine(item3);
               }
               Console.ReadLine();

           }
       }



    //2Q

    struct Books
    {
        int book_id;
        public int Book_id
        {
            get { return book_id; }
            set { book_id = value; }
        }
        public Books(int book_id)
        {
            this.book_id = book_id;
        }
        public void value(int value)
        {
            Console.WriteLine("the book id is " + book_id + " \nthe value of book " + value);
        }
    }
    class StructEg1
    {
        static void Main()
        {
            Books book1 = new Books(1768);
            book1.value(1000);
            Console.ReadLine();
        }
    }
        












































}







