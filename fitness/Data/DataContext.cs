using fitness.Models.Users;
using fitness.Models.Trainers;
using Microsoft.EntityFrameworkCore;

namespace fitness.Data;


    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users {get;set;}
        public DbSet<Trainer> Trainers {get; set;}
    }