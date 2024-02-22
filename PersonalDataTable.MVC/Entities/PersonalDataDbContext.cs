using Microsoft.EntityFrameworkCore;

namespace PersonalDataTable.MVC.Entities
{
    public class PersonalDataDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Email> Emails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PersonalDataTableMVC;Trusted_Connection=True;");
        }
    }
}
