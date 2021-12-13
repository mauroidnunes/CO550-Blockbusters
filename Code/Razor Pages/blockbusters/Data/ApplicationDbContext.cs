using blockbusters.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace blockbusters.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> People { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<PersonReview> PeopleReviews { get; set; }

        public DbSet<PersonGenre> PeopleGenres { get; set; }
    }
}
