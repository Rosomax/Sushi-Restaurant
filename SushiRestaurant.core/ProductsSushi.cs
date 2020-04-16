using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SushiRestaurant.core
{
    public class ProductsSushi
    {
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        [ForeignKey("Sushi")]
        public int SushiId { get; set; }
        public virtual Products Products { get; set; }
        public virtual Sushi Sushi { get; set; }
    }
}
