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

namespace ostosAppi_api.Data
{
    public class MvcShoppingListContext : DbContext
    {
        public MvcShoppingListContext(DbContextOptions<MvcShoppingListContext> options) : base(options)
        {

        }

        public DbSet<ShoppingList> ShoppingList { get; set; }
        public DbSet<ShoppingItem> ShoppingItem { get; set; }
    }
}
