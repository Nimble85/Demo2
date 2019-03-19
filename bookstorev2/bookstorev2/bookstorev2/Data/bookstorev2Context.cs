using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bookstorev2;

namespace bookstorev2.Models
{
    public class bookstorev2Context : DbContext
    {
        public bookstorev2Context (DbContextOptions<bookstorev2Context> options)
            : base(options)
        {
        }

        public DbSet<bookstorev2.Students> Students { get; set; }
    }
}
