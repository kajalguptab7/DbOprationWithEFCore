using Microsoft.EntityFrameworkCore;

namespace DbOprationWithEfCore.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyType>().HasData(
                new CurrencyType { Id = 1, Title = "INR", Description = "Indian INR" },
                new CurrencyType { Id = 2, Title = "Dollar", Description = "Dollar" },
                new CurrencyType { Id = 3, Title = "Euro", Description = "Euro" },
                new CurrencyType { Id = 4, Title = "Dinar", Description = "Dinar" }
                );
            modelBuilder.Entity<Language>().HasData(
               new Language { Id = 1, Title = "Hindi", Description = "Hindi" },
               new Language { Id = 2, Title = "Punjabi", Description = "Punjabi" },
               new Language { Id = 3, Title = "Tamil", Description = "Tamil" },
               new Language { Id = 4, Title = "Urdu", Description = "Urdu" }
               );
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<CurrencyType> CurrencyType { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
