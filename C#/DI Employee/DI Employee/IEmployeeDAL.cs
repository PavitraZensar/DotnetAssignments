using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Employee
{
    public interface IEmployeeDAL
    {
        List<Employee> GetAllEmployees();
        
    }
}