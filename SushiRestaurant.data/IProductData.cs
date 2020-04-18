using SushiRestaurant.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SushiRestaurant.data
{
    public interface IProductData
    {
        IEnumerable<Products> GetByName(string name);
        Products GetById(int id);
        Products AddProduct(Products newProdukt);
        Products UpdateProdukt(Products updatedProdukt);
        Products DeleteProdukt(int id);
        int SaveChanges();
    }
}
