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

        [BindProperty]
        public Users User { get; set; }
        public AdminLoginModel(IUserData userData)
        {
            this.userData = userData;
        }

        public IActionResult OnGet(int? userId)
        {

            if (userId.HasValue)
            {
                User = userData.GetById(userId.Value);
            }
            else
            {
                User = new Users();
            }
            if (User == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult OnPost()
        {

            if (userData.Verify(User)) return RedirectToPage("./ProductsManage");
            else return RedirectToPage("/Index");

        }
    }
}