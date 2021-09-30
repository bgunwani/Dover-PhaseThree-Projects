using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace coreCodeFirstRelationshipsApplication.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBiography> AuthorBiographies { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EI4423A;Database=DoverCorpDB;Integrated Security=true;");
        }
    }
}
