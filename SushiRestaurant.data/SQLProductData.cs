using SushiRestaurant.core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SushiRestaurant.data
{
    public class SQLProductData : IProductData
    {
        private readonly SushiRestaurantDbContext dbP;

        public SQLProductData(SushiRestaurantDbContext dbP)
        {
            this.dbP = dbP;
        }

        public Products AddProduct(Products newProdukt)
        {
            dbP.Add(newProdukt);
            return newProdukt;
        }

        public Products DeleteProdukt(int id)
        {
            var produkt = GetById(id);
            if (produkt != null)
            {
                dbP.Remove(produkt);
            }
            return produkt;
        }

        public Products GetById(int id)
        {
            return dbP.Products.Find(id);
        }

        public IEnumerable<Products> GetByName(string name)
        {
            var produktyLista = from p in dbP.Products
                          where p.NazwaProdukt.StartsWith(name) || string.IsNullOrEmpty(name)
                          orderby p.NazwaProdukt
                          select p;
            return produktyLista;
        }

        public int SaveChanges()
        {
            return dbP.SaveChanges();
        }

        public Products UpdateProdukt(Products updatedProdukt)
        {
            var entity = dbP.Products.Attach(updatedProdukt);
            entity.State = EntityState.Modified;
            return updatedProdukt;
        }
    }
}
