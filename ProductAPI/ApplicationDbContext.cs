using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;
using ProductAPI.Models.Account;
using ProductAPI.Models.Contact;


namespace ProductAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<AccountModel> AccountData { get; set; }

        public DbSet<ContactModel> ContactData { get; set; }

        




        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Optional: configure table names, relationships, etc.
            modelBuilder.Entity<AccountModel>().ToTable("CustomerData");
        }*/
    }
}
