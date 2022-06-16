using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAY2Webapplication.Models;

namespace DAY2Webapplication.Data
{
    public class DAY2WebapplicationContext : DbContext
    {
        public DAY2WebapplicationContext (DbContextOptions<DAY2WebapplicationContext> options)
            : base(options)
        {
        }

        public DbSet<DAY2Webapplication.Models.Student> Student { get; set; }
    }
}
