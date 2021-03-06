﻿using Kaida.Database.Models.Guilds;
using Kaida.Database.Models.Infrastructure;
using Kaida.Database.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Kaida.Database
{
    public class KaidaContext : DbContext
    {
        private readonly string server;
        private readonly string database;
        private readonly string username;
        private readonly string password;

        public KaidaContext(string server, string database, string username, string password)
        {
            this.server = server;
            this.database = database;
            this.username = username;
            this.password = password;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<Statistic> Statistics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql($"server={this.server};database={this.database};user={this.username};pwd={this.password};");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
