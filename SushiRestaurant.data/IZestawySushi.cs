using SushiRestaurant.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SushiRestaurant.data
{
    public interface IZestawySushi
    {
            ZestawySushi GetById(int id);
    }
}
