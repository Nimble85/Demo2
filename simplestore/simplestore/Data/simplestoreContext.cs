using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace simplestore.Models
{
    public class simplestoreContext : DbContext
    {
        public simplestoreContext (DbContextOptions<simplestoreContext> options)
            : base(options)
        {
        }

        public DbSet<simplestore.Models.books> books { get; set; }
    }
}
