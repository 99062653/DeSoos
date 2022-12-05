using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DeSoos.Models;
using System.Security.Cryptography.X509Certificates;

namespace DeSoos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
