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

        public DbSet<Payment> Order { get; set; }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<Movie> OrderItem { get; set; }

        public DbSet<Person> PersonReview { get; set; }
    }
}
