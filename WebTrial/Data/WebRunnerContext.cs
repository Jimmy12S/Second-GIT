using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTrial.Models;

namespace WebTrial.Data
{
    public class WebRunnerContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }

        public WebRunnerContext(DbContextOptions<WebRunnerContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
    }
}
