using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SushiRestaurant.core
{
    public class ZestawySushi
    {
        [ForeignKey("Sushi")]
        public int SushiId { get; set; }
        [ForeignKey("Zestawy")]
        public int ZestawyId { get; set; }
        public virtual Sushi Sushi { get; set; }
        public virtual Zestawy Zestawy { get; set; }
    }
}
