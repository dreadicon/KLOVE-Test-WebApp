using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KLOVE_webapp_test.Models;

namespace KLOVE_webapp_test.Models
{
    public class KLOVE_webapp_testContext : DbContext
    {
        public KLOVE_webapp_testContext (DbContextOptions<KLOVE_webapp_testContext> options)
            : base(options)
        {
        }

        public DbSet<KLOVE_webapp_test.Models.Employee> Employee { get; set; }

        public DbSet<KLOVE_webapp_test.Models.Department> Department { get; set; }
    }
}
