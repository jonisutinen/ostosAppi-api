using Microsoft.EntityFrameworkCore;
using ostosAppi_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Infraestructure;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ostosAppi_api.Controllers;

namespace ostosAppi_api.Data
{
    public class MvcShoppingListContext : DbContext
    {
        public MvcShoppingListContext(DbContextOptions<MvcShoppingListContext> options) : base(options)
        {

        }

        public DbSet<ShoppingList> ShoppingList { get; set; }
        public DbSet<ShoppingItem> ShoppingItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ShoppingList>(a =>
            {
                a.HasData(
                    new ShoppingList
                    {
                        Id = 1,
                        Name = "Ostokset1",
                        Store = "Prisma",
                        IsDone = false,
                        Created = DateTime.Now,
                        CreatedBy = "DBInit",
                        Updated = DateTime.Now,
                        UpdatedBy = "DBInit",
                    });
                a.OwnsMany(b => b.ShoppingItem).HasData(
                    new ShoppingItem
                    {
                        Id = 2,
                        Name = "Banaani",
                        Amount = 5,
                        AmountUnit = "kpl",
                        Price = 0,
                        IsCollected = false,
                        ShoppingListId = 1
                    },
                    new ShoppingItem
                    {
                        Id = 3,
                        Name = "Rahka",
                        Amount = 1,
                        AmountUnit = "kpl",
                        Price = 0,
                        IsCollected = false,
                        ShoppingListId = 1
                    },
                    new ShoppingItem
                    {
                        Id = 4,
                        Name = "Jauheliha",
                        Amount = 700,
                        AmountUnit = "g",
                        Price = 0,
                        IsCollected = false,
                        ShoppingListId = 1
                    });
            });
        }
    }
}
