using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    //1.Employee program
    public class Employee
    {
      
        public string EmpName;
        public int EmpId;
        public float salary;

        public Employee( string EmpName, int EmpId, float salary)
        {
            this.EmpName = EmpName;
            this.EmpId = EmpId;
            this.salary = salary;
        }
        public void dispDetails()
        {
            Console.WriteLine($"\nEmpName {EmpName} with Empid {EmpId} gets salary of {salary}");
        }
    }
    public class PartTimeemployee
    {
        public int wages = 1500;

        public void showDetails()
        {
            Console.WriteLine($"the parttime employee gets " + wages);
        }
    } 
        
    //2. Graduate and undergraduate student result program

    public abstract class Student
    {
        public String Name;
        public int StudentId;
        public abstract void BooleanIspassed(int Grade);
    }
  
    public class Undergraduate : Student
    {
        public override void BooleanIspassed(int Grade)
        {
            try
            {

                Console.WriteLine("Enter the undergraduate student Grade ");
                Grade = Convert.ToInt32(Console.ReadLine());
                if (Grade > 70)
                {
                    Console.WriteLine("undergraduate student passed the course ");
                }
                else
                {
                    Console.WriteLine("undergraduate student failed the course ");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("input mismatch exception " + e.StackTrace);
            }
        }
    }
    
    class Graduate : Student
    {
        public override void BooleanIspassed(int Grade)
        {
            try
            {
                Console.WriteLine("\nEnter the graduate student Grade");
                Grade = Convert.ToInt32(Console.ReadLine());
                if (Grade > 80)
                {
                    Console.WriteLine("Graduate student passed the course ");
                }
                else
                {
                    Console.WriteLine("Graduate student failed the course ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("input mismatch exception " + e.StackTrace);
            }
        }
    }




    //3.Student details program
    public class Students
    {
        public int stuId;
        public double examfee;
        public string stuName;
        


        public void displayDetails()
        {
            Console.WriteLine($"\nThe student {stuName} with id {stuId} has paid {examfee}");
        }
        public void payFee()
        {
            Console.WriteLine("\nEnter student id: ");
            stuId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student name: ");
            stuName = Console.ReadLine();
            Console.WriteLine("the Exam fee: is" + 1200);
            Console.WriteLine("Enter the amount to pay examfee");
            examfee = int.Parse(Console.ReadLine());
            double remfee = 1200 - examfee;
            if (examfee == 1200)
            {
                Console.WriteLine("Full fee paid by the student");
            }
            else
            {
                Console.WriteLine("the remaining fee: " + remfee);
            }
        }
    }
    class DayScholar
    {
        public double Transportfees;

        public DayScholar(double Transportfees)
        {
            this.Transportfees = Transportfees;
            double Rem1fee = 15000 - Transportfees;

            Console.WriteLine("\nthe Transport fee: " + 150000 + "per year ");


            Console.WriteLine($"The Dayscholar  paid {Transportfees} & remaining fee is {Rem1fee}");
            Console.WriteLine();
        }

    }
    public class Hosteller
    {
        public double hostelfee;

        public Hosteller(double hostelfee)
        {

            this.hostelfee = hostelfee;

            double rem2fee = 20000 - hostelfee;
            Console.WriteLine("The Hostel  fee: " + 20000 + "per year ");

            Console.WriteLine($"The Hosteller  paid {hostelfee} & remaining fee is {rem2fee} ");
            Console.WriteLine();
        }
    }



   internal class program
    { 
       static void Main(string[] args)
       {

        Employee employee = new Employee(230, "Pavitra", 30000.00f);
        employee.dispDetails();
        PartTimeemployee ptemployee = new PartTimeemployee();
        ptemployee.showDetails();
        
                   
        Undergraduate ug = new Undergraduate();
        ug.BooleanIspassed(10);
        ug.Name = "Pavitra";
        ug.StudentId = 230;
        Console.WriteLine($"Name is {ug.Name} & Id is {ug.StudentId}");

        Graduate g = new Graduate();
        g.Name = "Padma";
        g.StudentId = 287;
        g.BooleanIspassed(20);
        Console.WriteLine($"Name is {g.Name} & Id is {g.StudentId}");

 

        Students students = new Students();
        students.payFee();
        students.displayDetails();
        Console.WriteLine("Enter the tranport fee to be paid: ");
        DayScholar dayScholar = new DayScholar(int.Parse(Console.ReadLine()));
        Console.WriteLine("Enter the hostel fee to be paid: ");
        Hosteller hosteller = new Hosteller(int.Parse(Console.ReadLine()));

        Console.ReadLine();
    }
  }
}
