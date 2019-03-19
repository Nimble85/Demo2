using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bookstorev6;

namespace bookstorev6.Models
{
    public class bookstorev6Context : DbContext
    {
        public bookstorev6Context (DbContextOptions<bookstorev6Context> options)
            : base(options)
        {
        }

        public DbSet<bookstorev6.books> books { get; set; }
    }
}
