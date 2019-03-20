using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bookstorev11;

namespace bookstorev11.Models
{
    public class bookstorev11Context : DbContext
    {
        public bookstorev11Context (DbContextOptions<bookstorev11Context> options)
            : base(options)
        {
        }

        public DbSet<bookstorev11.books> books { get; set; }
    }
}
