using Microsoft.EntityFrameworkCore;
using SushiRestaurant.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SushiRestaurant.data
{
    public class SushiRestaurantDbContext : DbContext
    {
        public SushiRestaurantDbContext(DbContextOptions<SushiRestaurantDbContext> options):base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductsSushi> ProductsSushi { get; set; }
        public DbSet<Sushi> Sushi { get; set;}
        public DbSet<ZestawySushi> ZestawySushi { get; set; }
        public DbSet<Zestawy> Zestawy { get; set; }
    }
}
