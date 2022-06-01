using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MainProject_Nunit;

namespace TestingMainProject
{
    [TestFixture]
    public class EmployeeTester
    {
        List<Employee> elist;

        [Test]

        public void CheckAllEmployeeDetails()
        {
            Employee emp = new Employee();
            elist = emp.AllEmployees();

            foreach(var v in elist)
            {
                Assert.IsNotNull(v.ID);
                Assert.IsNotNull(v.Name);
                Assert.IsNotNull(v.Gender);
                Assert.IsNotNull(v.Salary);
            }
        }

        [Test]

        public void TesttheLogin()
        {
            Employee emp = new Employee();

            string s1 = emp.Login("Pavitra", "Admin123");
            string s2 = emp.Login("", "");
            string s3 = emp.Login("Admin", "Admin123");

            Assert.AreEqual("Invalid Userid or Password", s1);
            Assert.AreEqual("Welcome Admin", s3);
            Assert.AreEqual("User Id or Password Cannot be Empty", s2);

        }


        public void GetEmployeebyid_should_return_empty_if_idonotmatching()
        {
            Employee emp = new Employee();
            List<Employee> returnedemp = emp.GetEmployeeByID(1);
            Assert.IsEmpty(returnedemp);
            List<Employee> returnedemp1 = emp.GetEmployeeByID(100);
            Assert.IsNull(returnedemp);
        }
    }
}
