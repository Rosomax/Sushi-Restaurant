using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SushiRestaurant.core
{
    public class Products
    {
        [Key]
        public int ProduktId { get; set; }
        [Required]
        public string NazwaProdukt { get; set; }
        public string JednostkaProdukt { get; set; }
        public double IloscProdukt { get; set; }
        public virtual ICollection<ProductsSushi> ProduktSushi { get; set; }

    }
}
