using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SushiRestaurant.core
{
    public class Zestawy
    {
        [Key]
        public int ZestawyId { get; set; }
        [Required]
        public string NazwaZestaw { get; set; }

    }
}
