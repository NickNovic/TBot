using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code.Models;
using Microsoft.EntityFrameworkCore;

namespace Code
{
    public class UsersDbContext : DbContext
    {
        public DbSet<User> UsersDb{ get; set; }
        public DbSet<Exercise> ExercisesDb { get; set; }

        public UsersDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=UsersDb;Username=postgres;Password=1256");
        }
    }
}