using Company_WebSite.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company_WebSite.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "55-66-77-88",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "98-34-54-23",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "fer@gmail.com",
                NormalizedEmail ="FER@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null,"superpassword"),
                SecurityStamp = string.Empty
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
              RoleId = "45-34-12-76",
              UserId = "42-29-73-65"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("54-23-72-16"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("54-18-71-56"),
                CodeWord = "PageServices",
                Title = "Наши услуги"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("67-11-87-01"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });






        }
    }
}
