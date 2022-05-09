using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //1) To find average of an array elements
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int i, n;
            int sum = 0;
            float average = 0.0F;

            for (i = 0; i < arr.Length; i++)
             {
               n=Convert.ToInt32(Console.ReadLine());
               sum += n;      
             }
            average = sum / arr.Length;
            Console.WriteLine("Average of array elements is {0}", average);
            Console.WriteLine("Sum of array elements is {0}", sum);
            Console.Read();




            //2) To find maximum and minimum elemts in an array
             int[] arr = new int[5] { 10, 12, 24, 36, 18 };
             int i, max, min, n;
              n = 5;
              max = arr[0];
              min = arr[1];   
              for(i = 1; i < n; i++)
                {
                 if(arr[i] > max)
                   {
                    max= arr[i]; 
                   }
                 if(arr[i] < min)
                   {
                   min= arr[i];
                   }
                 }
              Console.WriteLine("Maximum element is {0}", max);
              Console.WriteLine("Minimum element is {0}", min);
              Console.Read();

            
            //3) Display marks in ascending order
            int n, i,j, temp;
            Console.Write("Enter array size:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter marks of the student:");
            for (i = 0; i < n; i++)
            {
              Console.Write("Marks -{0}:", i);
              arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
             {
               for (j = 0; j < n; j++)
               {
                 if (arr[j] > arr[i])
                  {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                  }
               }
            }
            Console.Write("\nMarks of students in ascending order is:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}", arr[i]);
                Console.Read();
            }
            


            //4) Descending order of marks
            int i, j, temp;
            int[] arr = new int[10] {1,2,3,4, 5, 6,7,8,9,10};
            Console.WriteLine("Entered Marks");
            for (i = 0; i < 10; i++)
            {
              Console.WriteLine("{0}", arr[i]);
            } 
            for (i = 0; i < 10; i++)
            {
              for (j = i+1; j < 10; j++)
              {
                if (arr[i] < arr[j])
                {
                  temp = arr[i];
                  arr[i] = arr[j];
                  arr[j] = temp;
                }
              }
            }
            Console.Write("\nMarks of students in descending order is:\n");
            for (i = 0; i < 10; i++)
            {
              Console.Write("{0}", arr[i]);
              Console.Write("\n\n");
              Console.Read();
            }


            //5) Comparing of two strings
            Console.WriteLine("Enter Word1");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter Word2");
            string word2 = Console.ReadLine();
            char[] chars = word1.ToCharArray(); 
            char[] chars2 = word2.ToCharArray();    
            int temp = 0;
            for(int i = 0; i < chars.Length; i++)
            {
               if(chars[i] != chars2[i])
               {
                temp++;
               }
            }
            if(temp == 0)
            {
               Console.WriteLine("Two words are  same");
            }
            else
            {
             Console.WriteLine("Two words are not same");
             Console.Read();
            }



            //6) Reverse a string
            Console.WriteLine("Enter your name");
            String s2 = Console.ReadLine();
            char[] chars = s2.ToCharArray();
            string s3 = "";
            for (int i = s2.Length - 1; i >= 0; i--)
            {
               s3 += chars[i];
            }
             Console.WriteLine(s3);
             Console.ReadLine();





            //7) Length of the string program
            Console.WriteLine("Welcome to Zensar Enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("The length of your name is {0}", name.Length);
            Console.Read();




            //8) Given String is a palindrome or not
            Console.WriteLine("Enter a word");
            string s5 = Console.ReadLine();
            char[] cha3 = s5.ToCharArray();
            int temp = 0;
            int j = cha3.Length - 1;
            for (int i = 0; i < j; i++)
            {
                if (cha3[i] != cha3[i + 1])
                {
                    temp = i;
                }
            }
            j--;
            if (temp! = 0)
            {
                Console.WriteLine("It's not a palindrome");
            }
            else
            {
                Console.WriteLine("It's a palindrome");
                Console.Read();
            }


        }
    }
}
