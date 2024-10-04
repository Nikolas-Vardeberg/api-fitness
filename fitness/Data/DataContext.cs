using fitness.Models.Users;
using Microsoft.EntityFrameworkCore;
using fitness.Models;

namespace fitness.Data;


    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users {get;set;}
        public DbSet<Gym> Gyms {get; set;}
    }