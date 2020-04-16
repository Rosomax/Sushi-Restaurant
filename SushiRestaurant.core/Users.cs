using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SushiRestaurant.core
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Login jest wymagany."),
         StringLength(12,ErrorMessage ="Login musi mieć minimum 5 a maksymalnie 12 znaków",MinimumLength=5)]
        public string Login { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane."),
         StringLength(12, ErrorMessage = "Hasło musi mieć minimum 5 a maksymalnie 12 znaków", MinimumLength = 5)]
        public string Password { get; set; }
    }
}
