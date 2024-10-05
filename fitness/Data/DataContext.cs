using fitness.Models.Users;
using Microsoft.EntityFrameworkCore;
using fitness.Models;

namespace fitness.Data;


    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users {get;set;}
        public DbSet<Gym> Gyms {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
          modelBuilder.Entity<Gym>(entity =>
        {
            entity.OwnsOne(c => c.OpeningHours,
                d =>
                {
                    d.ToJson();
                    
                    d.OwnsOne(o => o.Monday);
                    d.OwnsOne(o => o.Tuesday);
                    d.OwnsOne(o => o.Wednesday);
                    d.OwnsOne(o => o.Thursday);
                    d.OwnsOne(o => o.Friday);
                    d.OwnsOne(o => o.Saturday);
                    d.OwnsOne(o => o.Sunday);
                });
            
            entity.HasIndex(s => s.Slug).IsUnique();
        });
    }
}