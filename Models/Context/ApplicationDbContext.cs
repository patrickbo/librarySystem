using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Models.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ } 

        public DbSet<Book> Books { get; set; }        
        public DbSet<Secao> Secoes { get; set; }
    }
}