using Microsoft.EntityFrameworkCore;

namespace GestBookRazorPages.Models
{
    public class GestBookContext : DbContext
    {
        public GestBookContext(DbContextOptions<GestBookContext> options)
           : base(options)
        {
            //Database.EnsureCreated();
            try
            {
                Database.EnsureCreated();
            }
            catch (Exception ex) { throw ex; }
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Salt> Salts { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
