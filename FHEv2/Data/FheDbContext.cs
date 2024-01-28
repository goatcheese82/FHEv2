using FHEv2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace FHEv2.Data
{
    public class FheDbContext : DbContext
    {
        public FheDbContext(DbContextOptions<FheDbContext> options) : base(options) { }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<FHEv2.Models.Member> Member { get; set; } = default!;
        public DbSet<FHEv2.Models.Assignment> Assignment { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>()
                .HasMany(m => m.Members)
                .WithMany(m => m.Meetings)
                .UsingEntity<Assignment>();

            modelBuilder.Entity<Member>()
                .HasMany(m => m.Meetings)
                .WithMany(m => m.Members)
                .UsingEntity<Assignment>();
        }
    }
}
