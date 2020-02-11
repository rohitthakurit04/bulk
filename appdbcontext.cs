using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit Pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "cheese cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "seasonal Pies" });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "Apple pie",
                Price = 12.95M,
                ShortDescription = "our famous apple pies!",
                LongDescription = "Icing carrot cake jelly`o cheesecakes sweet roll marzipan marshmallow toffee",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name = "Blueberry cheese cake ",
                Price = 12.95M,
                ShortDescription = "you'll love it!",
                LongDescription = "Icing carrot cake jelly`o cheesecakes sweet roll marzipan marshmallow toffee",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                Name = "rhubarb pie",
                Price = 12.95M,
                ShortDescription = "our famous apple pies!",
                LongDescription = "Icing carrot cake jelly`o cheesecakes sweet roll marzipan marshmallow toffee",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 4,
                Name = "Apple pie",
                Price = 12.95M,
                ShortDescription = "our famous apple pies!",
                LongDescription = "Icing carrot cake jelly`o cheesecakes sweet roll marzipan marshmallow toffee",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 5,
                Name = "Apple pie",
                Price = 12.95M,
                ShortDescription = "our famous apple pies!",
                LongDescription = "Icing carrot cake jelly`o cheesecakes sweet roll marzipan marshmallow toffee",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 6,
                Name = "Apple pie",
                Price = 12.95M,
                ShortDescription = "our famous apple pies!",
                LongDescription = "Icing carrot cake jelly`o cheesecakes sweet roll marzipan marshmallow toffee",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 7,
                Name = "Apple pie",
                Price = 12.95M,
                ShortDescription = "our famous apple pies!",
                LongDescription = "Icing carrot cake jelly`o cheesecakes sweet roll marzipan marshmallow toffee",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 8,
                Name = "Apple pie",
                Price = 12.95M,
                ShortDescription = "our famous apple pies!",
                LongDescription = "Icing carrot cake jelly`o cheesecakes sweet roll marzipan marshmallow toffee",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 9,
                Name = "Apple pie",
                Price = 12.95M,
                ShortDescription = "our famous apple pies!",
                LongDescription = "Icing carrot cake jelly`o cheesecakes sweet roll marzipan marshmallow toffee",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 10,
                Name = "Apple pie",
                Price = 12.95M,
                ShortDescription = "our famous apple pies!",
                LongDescription = "Icing carrot cake jelly`o cheesecakes sweet roll marzipan marshmallow toffee",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 11,
                Name = "Apple pie",
                Price = 12.95M,
                ShortDescription = "our famous apple pies!",
                LongDescription = "Icing carrot cake jelly`o cheesecakes sweet roll marzipan marshmallow toffee",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });
        }
       
    }
}
