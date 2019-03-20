using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bookstorev9;

namespace bookstorev9.Models
{
    public class bookstorev9Context : DbContext
    {
        public bookstorev9Context (DbContextOptions<bookstorev9Context> options)
            : base(options)
        {
        }

        public DbSet<bookstorev9.books> books { get; set; }
    }
}
