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
    public class EditAddProductModel : PageModel
    {
        private readonly IProductData productData;

        [BindProperty]
        public Products Products { get; set; }
        //public IEnumerable<SelectListItem> selectListItems { get; set; }

        public EditAddProductModel(IProductData productData)
        {
            this.productData = productData;
        }

        public IActionResult OnGet(int? productId)
        {

            if (productId.HasValue)
            {
                Products = productData.GetById(productId.Value);
            }
            else
            {
                Products = new Products();
            }
            if (Products == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (Products.ProduktId > 0)
            {
                productData.UpdateProdukt(Products);
            }
            else
            {
               productData.AddProduct(Products);
            }

            productData.SaveChanges();
            TempData["Message"] = "Produkt został zapisany";
            return RedirectToPage("./Hidden/ProductsManage", new { produktId = Products.ProduktId });

        }
    }
}