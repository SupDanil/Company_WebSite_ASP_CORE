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
                Id = "iUNFjWQ5-ctP0-J3bH-uFi6-o3ihaf8tJNU7", 
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "oYV9cgjS-cPbA-hKvI-oe4v-M165pjc6i7xz", 
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
              RoleId = "iUNFjWQ5-ctP0-J3bH-uFi6-o3ihaf8tJNU7",   
              UserId = "oYV9cgjS-cPbA-hKvI-oe4v-M165pjc6i7xz"   
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = Guid.NewGuid(),    //"pVJNUVnD-ztci-8M0o-gFsj-fwPgijZku8"
                CodeWord = "PageIndex",
                Title = "Главная"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = Guid.NewGuid(),    //"wnHIk8jg-pGns-puIK-waeU-VerNyfF02u"
                CodeWord = "PageServices",
                Title = "Наши услуги"                                                
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = Guid.NewGuid(),                 //"PFKka935-3Hze-ce8G-PZNg-lXieLFGHqO"
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }
    }
}
