using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SushiRestaurant.core;
using SushiRestaurant.data;

namespace Sushi_Restaurant.Pages.Hidden
{
    public class ProductsManageModel : PageModel
    {
        private readonly IConfiguration configuration;
        private readonly IProductData productData;

        public IEnumerable<Products> Products  { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public ProductsManageModel(IConfiguration configuration, IProductData productData)
        {
            this.configuration = configuration;
            this.productData = productData;
        }

        public void OnGet(string searchTerm)
        {
            Products = productData.GetByName(searchTerm);
        }
    }
}