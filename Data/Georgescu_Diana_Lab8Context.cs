using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Georgescu_Diana_Lab8.Models;

namespace Georgescu_Diana_Lab8.Data
{
    public class Georgescu_Diana_Lab8Context : DbContext
    {
        public Georgescu_Diana_Lab8Context (DbContextOptions<Georgescu_Diana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Georgescu_Diana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Georgescu_Diana_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
