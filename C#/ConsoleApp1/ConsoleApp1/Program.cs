using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter integer 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer 2: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Two intergers are equal");
            }
            else
            {
                Console.WriteLine("Two interegrs are not equal");
                Console.Read();
            }

            // Que.2 Checking for Positive or Negative
            
            Console.WriteLine("Enter the number to check for Positive or Negative");
            int num3 = int.Parse(Console.ReadLine());
            if (num3>=0)
            {
                Console.WriteLine("Given Number is Positive");
            }
            else if(num3<0)
            {
                Console.WriteLine("Given Number is Negative");
                Console.Read();
            }
            // Que.3 Operator
            int number1, number2, result;
            char operation;
            Console.WriteLine("Enter the first number");
            Console.WriteLine("Enter the second number");
            number1 = Convert. ToInt32(Console.ReadLine());
            number2 = Convert. ToInt32(Console.ReadLine());
            Console.WriteLine("Choose the operation");
            Console.WriteLine("Addition");
            Console.WriteLine("Subtraction");
            Console.WriteLine("Division");
            Console.WriteLine("Multiplication");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '1':
                    result = number1 + number2;
                    Console.WriteLine("The addition of two numbers is : { 0} ", result);
                    break;
                case '2':
                    result = number1 - number2;
                    Console.WriteLine("The Subtraction of two numbers is : {0}", result);
                    break;
                case '3':
                    result = number1 / number2;
                    Console.WriteLine("The Division of two numbers is : { 0}", result);
                    break;
                case '4':
                    result = number1 * number2;
                    Console.WriteLine("The Multiplication of two numbers is : { 0}", result);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadLine();
        }
    }
}
