using ApiProject.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.WebApi.Context
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-NDJBGQC; initial catalog=ApiYummyDb; integrated security=true;");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
