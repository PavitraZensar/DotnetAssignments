using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student Marks
            int rollno;
            string name;
            string branch;
            string sem;
            string Class;

            static void displayResult()
            {
                int[] marks = new int[5];
                marks[0] = 1;
                marks[1] = 2;
                marks[2] = 3;
                marks[3] = 4;
                marks[4] = 5;
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.WriteLine("The Marks of subject " + i" is :", +marks[i]);
                }
                double average = marks.Average();
                for (int i = 0; i < marks.Length; i++)
                {
                    if (marks[i] < 35)
                    {
                        Console.WriteLine("FAILED");
                    }
                    else
                    {
                        if (marks[i] >> 35 && average < 50)
                        {
                            Console.WriteLine("PASSED");
                        }
                        else
                        {
                            Console.WriteLine("INVALID");
                        }
                    }
                }
                
                static Student(int rollno, string name, string branch, string sem, string Class)
                    {
                        this.rollno = rollno;
                        this.name = name;
                        this.branch = branch;
                        this.sem = sem;
                        this.Class = Class;
                        Console.WriteLine("\n Rollno is: {rollno}, Name is: {name}, Branch is: {branch}, Sem is: {sem}, Class is: {class}");
                    }
                    static void displayData()
                    {
                        Console.WriteLine("Marks of the student is:");
                        Student.displayResult();
                        Student student = new Student(24, "pavitra", "mech-1", "3-1", "mechanical");
                        student.displayData();
                    }
                    Console.ReadLine();
                }
            }
        }

            //Car program
        internal class Car
        {
            int car_no;
            string car_name;
            String car_type;
            readonly double cost = 500000;
            public Car(int car_no; string car_name; String car_type;)
            {
               this.car_no = car_no;
               this.car_name = car_name;
               this.car_type = car_tpe;
               this.cost = Cost;
               Console.WriteLine("the car_no is {car_no}, car_name is {car_name}, car_type is {car_type}, car_cost is {car_cost}");
            }
        public void showDetails()
        {
            Console.WriteLine("Before changing");
            Console.WriteLine("the car_no is {car_no}, car_name is {car_name}, car_type is {car_type}, car_cost is {car_cost}");
           
            public Car(double car_cost)
          
        {
            Console.WriteLine("After changing");
            Console.WriteLine("the car_no is {car_no}, car_name is {car_name}, car_type is {car_type}, car_cost is {car_cost}");
                  
              car.showdetails();
              Car car = new Car(891, "Lamborgini", "Sports", 9000000);
              Car car2 = new Car(9000000);
          
        }
    }

    //Bank Loan program
    internal class bankloan
    {
        double interest;
        public void loanCalculator(double loanamount)
        {
            Console.WriteLine("Enter the rate of interest");
            interest = Convert.ToDouble(Console.ReadLine());
            double interest = (loanamount * interest) / 100;
            Console.WriteLine("Rate of interest for " + interestrate + " (in percentage) % is:" + interest);
                bank bank = new bank();
                Console.WriteLine("Enter the loan amount:");
                bank.loanCalculator(Convert.ToInt32(Console.ReadLine()));
        }
    }

  

























































        }
    }
    }


