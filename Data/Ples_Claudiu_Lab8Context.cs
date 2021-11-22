using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ples_Claudiu_Lab8.Pages.Models;

namespace Ples_Claudiu_Lab8.Data
{
    public class Ples_Claudiu_Lab8Context : DbContext
    {
        public Ples_Claudiu_Lab8Context (DbContextOptions<Ples_Claudiu_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ples_Claudiu_Lab8.Pages.Models.Book> Book { get; set; }

        public DbSet<Ples_Claudiu_Lab8.Pages.Models.Publisher> Publisher { get; set; }

        public DbSet<Ples_Claudiu_Lab8.Pages.Models.Category> Category { get; set; }
    }
}
