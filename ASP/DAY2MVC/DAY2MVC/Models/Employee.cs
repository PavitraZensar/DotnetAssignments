using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace DAY2MVC.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Display(Name = "Employee Name :")]
        public string Name { get; set; }
        [DisplayName("Date of Joining")]
        public Nullable<System.DateTime> DOJ { get; set; }
        public string Email { get; set; }
    }
}