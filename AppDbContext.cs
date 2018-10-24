using Microsoft.EntityFrameworkCore;
using WebApplication3.Business;
using WebApplication3.Models;

namespace WebApplication3
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<ApplicantModel> ApplicantModel { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\USER-PC;Database=Bank;Trusted_Connection=True;ConnectRetryCount=0");
           
        }

    }
}