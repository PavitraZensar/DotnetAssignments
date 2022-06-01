using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BasicAdo1
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
           // InsertTableAData();
            //SelectData();
            //GetScalarFunc();
           // DeleteTableA();
            UpdatetblEmployee();
            //SelectData();
            Console.Read();
        }

        public static void DeleteTableA()
        {
            con = getCon();
            Console.WriteLine("Enter TableA Name to delete :");
            string tName = Console.ReadLine();
            cmd = new SqlCommand("delete from Tablea where tName=@tName", con);
            cmd.Parameters.AddWithValue("@tName", tName);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
                Console.WriteLine("record deleted");
            else
                Console.WriteLine("Not deleted");
        }
        public static void InsertTableAData()
        {
            con = getCon();
            Console.WriteLine("Enter TableID:");
            int tID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            string tName = Console.ReadLine();
            Console.WriteLine("Enter Gender:");
            string tgender =Console.ReadLine();
            Console.WriteLine("Enter Department :");
            string tdepartment = Console.ReadLine();
            cmd = new SqlCommand("Insert into TableA values(@ID,@Name,@gender,@department)", con);
            cmd.Parameters.AddWithValue("@ID", tID);
            cmd.Parameters.AddWithValue("@Name", tName);
            cmd.Parameters.AddWithValue("@gender", tgender);
            cmd.Parameters.AddWithValue("@department", tdepartment);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Added one record.");
            }
            else
                Console.WriteLine("Something went wrong.. did not insert");
        }
        public static void UpdatetblEmployee()
        {
            con = getCon();
            Console.WriteLine("Enter Salary to update:");
            int Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter EmpNo to update :");
            int EmpNo = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand(" update tblEmployee set Salary =@Salary where EmpNo =@EmpNo", con);
            cmd.Parameters.AddWithValue("@Salary", Salary);
            cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
            int result = cmd.ExecuteNonQuery();

            if (result > 0)
                Console.WriteLine("Record updated");
            else
                Console.WriteLine("not updated");
        }


        public static void GetScalarFunc()
        {
            con = getCon();
            cmd = new SqlCommand("select count(EmpNo) from tblEmployee", con);
            int empcount = Convert.ToInt32(cmd.ExecuteScalar()); // execute scalar returns object
            Console.WriteLine("No.of Employees :{0}", empcount);
        }
        public static void SelectData()
        {
            con = getCon();
            //cmd = new SqlCommand("select * from tblEmployee", con);
            //or
            cmd = new SqlCommand("Select * from tblEmployee");
            cmd.Connection = con;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                // Console.WriteLine(dr[0] + " "+ dr[1]+" " + dr[2] + " " + dr[3]);
                //or
                Console.WriteLine("Employee No : " + dr[0]);
                Console.WriteLine("Employee Name : " + dr[1]);
                Console.WriteLine("Employee Job : " + dr[2]);
                Console.WriteLine("Employee Mgr : " + dr[3]);
            }

        }

        public static SqlConnection getCon()
        {
            con = new SqlConnection("data source=ADMW46ZLPC1609\\SQLEXPRESS;Initial Catalog=Assign2DB;" + "Integrated Security=true;");
            //new SqlConnection("data source=ADMW46ZLPC1609\\SQLEXPRESS;Initial Catalog=Assign2db;" + "user id=sa; password=Temp1234");
            con.Open();
            return con;
        }
    }
}