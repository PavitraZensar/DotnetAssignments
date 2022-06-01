using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace adopractice
{
   
        class Program
        {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        

        static void Main(string[] args)
        {
            InsertData();
            Console.Read();
        }

       
        public static void InsertData()
        {
            try
            {
                con = getCon();
                Console.WriteLine("Enter Employee Details : ");
                string ename, etype;
                float esal;
                Console.WriteLine("Enter Employee Name : ");
                ename = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary : ");
                esal = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Type 'C' Or 'P' :");
                etype = Console.ReadLine();
                cmd = new SqlCommand("execute dbo.AddNewEmployee @ename, @esal, @etype");
                cmd.Parameters.AddWithValue("@ename", ename);
                cmd.Parameters.AddWithValue("@esal", esal);
                cmd.Parameters.AddWithValue("@etype", etype);
                cmd.Connection = con;
                int no_of_rows = cmd.ExecuteNonQuery();
                if (no_of_rows > 0)
                {
                    Console.WriteLine("Number of Rows affected are : {0} ", no_of_rows);
                }
                else
                {
                    Console.WriteLine("NO Rows Affected");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        public static SqlConnection getCon()
        {
            con = new SqlConnection("data source=ADMW46ZLPC1609\\SQLEXPRESS;Initial Catalog=EmployeeManagment;" + "user id=sa; password=Temp1234");
            con.Open();
            return con;
        }



    }
}
