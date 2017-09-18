using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCTest.Models
{
    public class MVCTestContext : DbContext
    {
       

        public MVCTestContext(DbContextOptions<MVCTestContext> options)
            : base(options)
        {
            
        }

        public DbSet<MVCTest.Models.Employee> Employee { get; set; }
    }
}
