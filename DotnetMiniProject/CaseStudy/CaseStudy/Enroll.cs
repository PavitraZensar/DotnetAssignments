using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class Enroll
    {
        public Student student { get; set; }
        public Course course { get; set; }
        public DateTime enrollmentDate { get; set; }
        public Enroll()
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }

    }
}