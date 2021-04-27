using eShopSolution.Data.Entities;
using eShopSolution.Data.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page" },
                new AppConfig() { Key = "HomeKeyWord", Value = "This is keyword" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description" }
            );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active
                    //CategoryTranslations = new List<CategoryTranslation>()
                    //{
                    //    new CategoryTranslation() {Id=1, CategoryId =1, Name = "Áo Nam", LanguageId = "vi-VN", SeoDescription = "San pham ao thoi trang nam", SeoAlias = "ao-nam", SeoTitle = "San pham ao thoi trang nam" },
                    //    new CategoryTranslation() {Id=2, CategoryId =1, Name = "Men Shirt", LanguageId = "en-US", SeoDescription = "Men Shirt", SeoAlias = "men-shirt", SeoTitle = "Men Shirt" }
                    //}
                },

                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                     // CategoryTranslations = new List<CategoryTranslation>()
                     //{
                     //    new CategoryTranslation() {Id=3, CategoryId =2,  Name = "Áo Nữ", LanguageId = "vi-VN", SeoDescription = "San pham ao thoi trang nu", SeoAlias = "ao-nu", SeoTitle = "San pham ao thoi trang nu" },
                     //    new CategoryTranslation() {Id=4, CategoryId =2, Name = "Women Shirt", LanguageId = "en-US", SeoDescription = "Women Shirt", SeoAlias = "Women-shirt", SeoTitle = "Women Shirt" }
                     //}
                 }
            );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                    new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Áo Nam", LanguageId = "vi", SeoDescription = "San pham ao thoi trang nam", SeoAlias = "ao-nam", SeoTitle = "San pham ao thoi trang nam" },
                    new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en", SeoDescription = "Men Shirt", SeoAlias = "men-shirt", SeoTitle = "Men Shirt" },
                    new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Áo Nữ", LanguageId = "vi", SeoDescription = "San pham ao thoi trang nu", SeoAlias = "ao-nu", SeoTitle = "San pham ao thoi trang nu" },
                    new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women Shirt", LanguageId = "en", SeoDescription = "Women Shirt", SeoAlias = "Women-shirt", SeoTitle = "Women Shirt" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 20000,
                    Stock = 0,
                    ViewCount = 0
                    //ProductTranslations = new List<ProductTranslation>()
                    //{
                    //    new ProductTranslation() { ProductId = 1, Name = "Áo Nam", LanguageId = "vi-VN", SeoDescription = "San pham ao thoi trang nam", SeoAlias = "ao-nam", SeoTitle = "San pham ao thoi trang nam", Details="Mo ta san pham", Description="" },
                    //    new ProductTranslation() { ProductId = 1, Name = "Men Shirt", LanguageId = "en-US", SeoDescription = "Men Shirt", SeoAlias = "men-shirt", SeoTitle = "Men Shirt", Details="Description", Description="" }
                    //},

                    //ProductInCategories = new List<ProductInCategory>()
                    //{
                    //    new ProductInCategory(){ProductId=1, CategoryId = 1 }
                    //}
                }
            );

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation() { Id = 1, ProductId = 1, Name = "Áo Nam", LanguageId = "vi", SeoDescription = "San pham ao thoi trang nam", SeoAlias = "ao-nam", SeoTitle = "San pham ao thoi trang nam", Details = "Mo ta san pham", Description = "" },
                new ProductTranslation() { Id = 2, ProductId = 1, Name = "Men Shirt", LanguageId = "en", SeoDescription = "Men Shirt", SeoAlias = "men-shirt", SeoTitle = "Men Shirt", Details = "Description", Description = "" }

            );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
            );

            //var ADMIN_ID = new Guid("4C4D5AF5-CF2D-4E11-A099-93DA905BAACF");
            // var ROLE_ID = ADMIN_ID;
            var roleId = new Guid("C9A4E043-D03B-484A-97EE-4A60806698CC");
            var adminId = new Guid("4C4D5AF5-CF2D-4E11-A099-93DA905BAACF");
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = roleId,
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Administrator role"
                }

                ) ;
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser()
                {
                    Id = adminId,
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "abc@gmail.com",
                    NormalizedEmail = "abc@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "SOME_ADMIN_PLAIN_PASSWORD"),
                    SecurityStamp = string.Empty,
                    FirstName= "Eric",
                    LastName = "T",
                    Dob = new DateTime(2020, 01, 21)
            }

            );

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>()
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
