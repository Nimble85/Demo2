using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bookstorev8;

namespace bookstorev8.Models
{
    public class bookstorev8Context : DbContext
    {
        public bookstorev8Context (DbContextOptions<bookstorev8Context> options)
            : base(options)
        {
        }

        public DbSet<bookstorev8.books> books { get; set; }
    }
}
