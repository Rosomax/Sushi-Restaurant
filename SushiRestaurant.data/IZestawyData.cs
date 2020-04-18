using SushiRestaurant.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SushiRestaurant.data
{
    public interface IZestawyData
    {
        IEnumerable<Zestawy> GetByName(string name);
        Zestawy GetById(int id);
        Zestawy AddNewZestawy(Zestawy newZestaw);
        Zestawy UpdateZestawy(Zestawy updatedZestawy);
        Zestawy DeleteZestawy(int id);
        int SaveChanges();
    }
}
