using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace bookstore
{
    public class Class StudentContext: DbContext
    {
         public DbSet<Student> Students { get; set; }

         public DbSet<Department> Departments { get; set; }

         public StudentContext(DbContextOptions options) : base(options) { }
}
}
