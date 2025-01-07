using Common.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class BusBookingSystemDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<SeatDetail> SeatDetails { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder
        //    // .UseSqlServer(@"Server=localhost;Database=BusBookingSystemDB;Trusted_Connection=True;")
        //    // .UseLazyLoadingProxies();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
             .UseSqlServer(@"Server=localhost;Database=BusBookingSystemDB;Trusted_Connection=True;")
             .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Username = "admin",
                    Password = "password@123",
                    FirstName = "Tatiana",
                    LastName = "Dragu", 
                    Email = "xyz@gmail.com"
                });
        }
    }
}
