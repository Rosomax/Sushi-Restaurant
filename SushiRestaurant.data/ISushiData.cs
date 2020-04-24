using SushiRestaurant.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SushiRestaurant.data
{
    public interface ISushiData
    {
        IEnumerable<Sushi> GetByName(string name);
        Sushi GetById(int id);
        Sushi AddNewSushi(Sushi newSushi);
        Sushi UpdateSushi(Sushi updatedSushi);
        Sushi DeleteSushi(int id);
        string GetSkladniki(int id);
        int SaveChanges();
    }
}
