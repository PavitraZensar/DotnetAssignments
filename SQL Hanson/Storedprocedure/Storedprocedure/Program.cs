using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Storedprocedure
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        private static void SelectProc()
        {
            con = getcon();
            Console.WriteLine("Please Enter the Emp id ");
            string csvariable = Console.ReadLine();
            //cmd = new SqlCommand("select *  from Product ");
            cmd = new SqlCommand("sp_findEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@eid", csvariable));
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " | " + dr[1] + " | " + dr[2] + " | " + dr[3]+" | "+dr[4]+" | "+dr[5]+" | "+dr[6]);
               /* Console.WriteLine("Emp id is : " + dr[0]);
                Console.WriteLine("Emp name is : " + dr[1]);
                Console.WriteLine("Emp Gender is : " + dr[2]);
                Console.WriteLine("Emp Salary is : " + dr[3]);
                Console.WriteLine("Emp Email is : " + dr[4]);
                Console.WriteLine("Emp Department is : " + dr[5]);
                Console.WriteLine("Emp Phoneno is : " + dr[6]);*/
            }

        }
        static void Main(string[] args)
        {
            SelectProc();
            Console.ReadLine();
        }

        public static SqlConnection getcon()
        {
            con = new SqlConnection("data source = ADMW46ZLPC1609\\SQLEXPRESS; Initial catalog = Zensardb; " + "user id= sa; password = Temp1234");
            con.Open();
            return con;
        }
    }
}