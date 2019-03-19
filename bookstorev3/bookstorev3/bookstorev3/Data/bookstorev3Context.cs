using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bookstorev3;

namespace bookstorev3.Models
{
    public class bookstorev3Context : DbContext
    {
        public bookstorev3Context (DbContextOptions<bookstorev3Context> options)
            : base(options)
        {
        }

        public DbSet<bookstorev3.Students> Students { get; set; }
    }
}
