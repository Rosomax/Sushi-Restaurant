using Microsoft.EntityFrameworkCore;
using SushiRestaurant.core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SushiRestaurant.data
{
    public class SQLSushiData : ISushiData
    {
        private readonly SushiRestaurantDbContext dbS;

        public SQLSushiData(SushiRestaurantDbContext dbS)
        {
            this.dbS = dbS;
        }

        public Sushi AddNewSushi(Sushi newSushi)
        {
            dbS.Add(newSushi);
            return newSushi;
        }

        public Sushi DeleteSushi(int id)
        {
            var sushiToDelete = GetById(id);
            if(sushiToDelete!=null)
            {
                dbS.Remove(sushiToDelete);
            }
            return sushiToDelete;
        }

        public Sushi GetById(int id)
        {
            return dbS.Sushi.Find(id);
        }

        public IEnumerable<Sushi> GetByName(string name)
        {
            var sushiLista = from s in dbS.Sushi
                                where s.NazwaSushi.StartsWith(name) || string.IsNullOrEmpty(name)
                                orderby s.NazwaSushi
                                select s;
            return sushiLista;
        }

        public string GetSkladniki(int id)
        {
            var entryPoint = (from s in dbS.Sushi
                              join ps in dbS.ProductsSushi on s.SushiId equals ps.SushiId
                              join p in dbS.Products on ps.ProductId equals p.ProduktId
                              where s.SushiId == id && s.SushiId == ps.SushiId && ps.ProductId== p.ProduktId
                              orderby p.NazwaProdukt
                              select new
                              {
                                  Składniki = p.NazwaProdukt.ToString()
                              }).Take(10);
            return entryPoint.ToString();
        }

        public int SaveChanges()
        {
            return dbS.SaveChanges();
        }

        public Sushi UpdateSushi(Sushi updatedSushi)
        {
            var entity = dbS.Attach(updatedSushi);
            entity.State = EntityState.Modified;
            return updatedSushi;
        }
    }
}
