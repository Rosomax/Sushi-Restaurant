using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SushiRestaurant.core
{
    public class Sushi
    {
        [Key]
        public int SushiId { get; set; }
        [Required]
        public string NazwaSushi { get; set; }
        public int IloscSushi { get; set; }
        public double CenaSushi { get; set; }
        public string OpisSushi { get; set; }
        public virtual ICollection<ProductsSushi> Składniki { get; set; }
    }
}
