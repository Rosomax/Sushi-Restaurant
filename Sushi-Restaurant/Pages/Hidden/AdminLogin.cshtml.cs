using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SushiRestaurant.core;
using SushiRestaurant.data;

namespace Sushi_Restaurant.Pages.Hidden
{
    public class AdminLoginModel : PageModel
    {
        private readonly IUserData userData;


        public Users User { get; set; }
        public AdminLoginModel(IUserData userData)
        {
            this.userData = userData;
        }

        public void OnGet()
        {

        }
    }
}