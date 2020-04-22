using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SushiRestaurant.core;
using SushiRestaurant.data;

namespace Sushi_Restaurant.Pages
{
    public class MenuModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly ISushiData sushiData;

        public IEnumerable<Sushi> Sushi { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public MenuModel(IConfiguration config, ISushiData sushiData)
        {
            this.config = config;
            this.sushiData = sushiData;
        }

        public void OnGet(string searchTerm)
        {
            Sushi = sushiData.GetByName(searchTerm);
        }
    }
}