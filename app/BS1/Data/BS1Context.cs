using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BS1;

namespace BS1.Models
{
    public class BS1Context : DbContext
    {
        public BS1Context (DbContextOptions<BS1Context> options)
            : base(options)
        {
        }

        public DbSet<BS1.books> books { get; set; }
    }
}
