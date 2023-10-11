﻿using Microsoft.EntityFrameworkCore;

namespace GestBookRazorPages.Models
{
    public class GestBookContext : DbContext
    {
        public GestBookContext(DbContextOptions<GestBookContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Salt> Salts { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
