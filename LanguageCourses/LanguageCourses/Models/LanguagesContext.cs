using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageCourses.Models
{
    public class LanguagesContext : IdentityDbContext
    {
        public new DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<LanguageLVL> LanguageLVLs { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>().HasKey(u => u.Id);
            modelBuilder.Entity<Teacher>().HasKey(u => u.id);
            modelBuilder.Entity<Admin>().HasKey(u => u.idAdmin);
            modelBuilder.Entity<Languages>().HasKey(u => u.idLanguage);
            modelBuilder.Entity<LanguageLVL>().HasKey(u => u.languageId);

        }
        public LanguagesContext()
        { }
        public LanguagesContext(DbContextOptions<LanguagesContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
