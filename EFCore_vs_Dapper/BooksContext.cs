using Microsoft.EntityFrameworkCore;

namespace EFCore_vs_Dapper
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var dbPath = @"C:\Code\PersonalProjects\EFCore_vs_Dapper\books.db";
            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}
