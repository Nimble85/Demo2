using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bookstorev5;

namespace bookstorev5.Models
{
    public class bookstorev5Context : DbContext
    {
        public bookstorev5Context (DbContextOptions<bookstorev5Context> options)
            : base(options)
        {
        }

        public DbSet<bookstorev5.books> books { get; set; }
    }
}
