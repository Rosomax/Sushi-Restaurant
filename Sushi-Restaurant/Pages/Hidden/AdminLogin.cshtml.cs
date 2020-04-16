using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SushiRestaurant.data;

namespace Sushi_Restaurant.Pages.Hidden
{
    public class AdminLoginModel : PageModel
    {
        private readonly IUserData userData;
        private readonly IHtmlHelper htmlHelper;

        public AdminLoginModel(IUserData userData, IHtmlHelper htmlHelper)
        {
            this.userData = userData;
            this.htmlHelper = htmlHelper;
        }

        public void OnGet()
        {

        }
    }
}