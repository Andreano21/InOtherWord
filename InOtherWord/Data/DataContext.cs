using Microsoft.EntityFrameworkCore;
using InOtherWord.Models;

namespace InOtherWord.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Dictionary> Dictionaries { get; set; } = null!;
        public DbSet<DictionaryPersonal> DictionaryPersonals { get; set; } = null!;
        public DbSet<Word> Words { get; set; } = null!;
        public DbSet<WordPersonal> WordPersonals { get; set; } = null!;


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Dictionary>().ToTable("Dictionary");
        //    modelBuilder.Entity<DictionaryPersonal>().ToTable("DictionaryPersonal");
        //    modelBuilder.Entity<Word>().ToTable("Word");
        //    modelBuilder.Entity<WordPersonal>().ToTable("WordPersonal");
        //}
    }
}