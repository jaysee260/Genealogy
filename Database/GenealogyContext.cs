using Microsoft.EntityFrameworkCore;
using Genealogy.Classes;

namespace Database
{
    public class GenealogyContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\MSSQL;Database=Genealogy;UID=user;Password=pass;Trusted_Connection=true");
        }
    }
}
