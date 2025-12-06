using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLayer;

namespace DataLayer
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(Connection.ConnectionString);
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Drivers> Drivers { get; set; }
        public DbSet<Buses> Buses { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Routes> Routes { get; set; }
        public DbSet<RoutePrices> RoutePrices { get; set; }
        public DbSet<Trips> Trips { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<CustomersCountries> CustomersCountries { get; set; }
        public DbSet<TripDTO> TripDTOs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }


            //          City And Country
            modelBuilder.Entity<Countries>().HasData(
               new Countries { CountryID = 1, CountryName = "Jordan" },
               new Countries { CountryID = 2, CountryName = "Egypt" },
               new Countries { CountryID = 3, CountryName = "Syria" },
               new Countries { CountryID = 4, CountryName = "Iraq" }
           );

            // Seed Cities
            modelBuilder.Entity<Cities>().HasData(
                // Jordan
                new Cities { CityID = 1, CityName = "Amman", CountryID = 1 },
                new Cities { CityID = 2, CityName = "Zarqa", CountryID = 1 },
                new Cities { CityID = 3, CityName = "Irbid", CountryID = 1 },
                new Cities { CityID = 4, CityName = "Aqaba", CountryID = 1 },

                // Egypt
                new Cities { CityID = 5, CityName = "Cairo", CountryID = 2 },
                new Cities { CityID = 6, CityName = "Alexandria", CountryID = 2 },
                new Cities { CityID = 7, CityName = "Giza", CountryID = 2 },
                new Cities { CityID = 8, CityName = "Sharm Elshiekh", CountryID = 2 },

                // Syria
                new Cities { CityID = 9, CityName = "Damascus", CountryID = 3 },
                new Cities { CityID = 10, CityName = "Aleppo", CountryID = 3 },
                new Cities { CityID = 11, CityName = "Homs", CountryID = 3 },

                // Iraq
                new Cities { CityID = 12, CityName = "Baghdad", CountryID = 4 },
                new Cities { CityID = 13, CityName = "Basra", CountryID = 4 },
                new Cities { CityID = 14, CityName = "Mosul", CountryID = 4 }
            );



            // Route -> Country relationships
            modelBuilder.Entity<Routes>()
                .HasOne(r => r.FromCountry)
                .WithMany(c => c.RoutesFrom)
                .HasForeignKey(r => r.FromCountryID);

            modelBuilder.Entity<Routes>()
                .HasOne(r => r.ToCountry)
                .WithMany(c => c.RoutesTo)
                .HasForeignKey(r => r.ToCountryID);

            modelBuilder.Entity<Routes>()
            .HasOne(r => r.FromCity)
            .WithMany(c => c.RoutesFrom)
            .HasForeignKey(r => r.FromCityID);

            modelBuilder.Entity<Routes>()
                .HasOne(r => r.ToCity)
                .WithMany(c => c.RoutesTo)
                .HasForeignKey(r => r.ToCityID);

            // RoutePrice composite relation (Route + User)
            modelBuilder.Entity<RoutePrices>()
                .HasOne(rp => rp.Route)
                .WithMany(r => r.RoutePrice)
                .HasForeignKey(rp => rp.RouteID);

            // Booking one-to-one with Payment
            modelBuilder.Entity<Bookings>()
                .HasOne(b => b.Payment)
                .WithOne(p => p.Booking)
                .HasForeignKey<Payments>(p => p.BookingID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
