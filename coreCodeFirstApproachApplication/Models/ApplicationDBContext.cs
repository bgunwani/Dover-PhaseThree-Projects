using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace coreCodeFirstApproachApplication.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configuring Connection String
            optionsBuilder.UseSqlServer("Server=DESKTOP-EI4423A;Database=DoverDB;Integrated Security=true;");  
        }

    }
}
