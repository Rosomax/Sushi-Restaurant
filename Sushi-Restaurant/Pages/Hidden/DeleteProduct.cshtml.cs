using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SushiRestaurant.core;
using SushiRestaurant.data;

namespace Sushi_Restaurant.Pages.Hidden
{
    public class DeleteProductModel : PageModel
    {
        private readonly IProductData productData;
        public Products Produkt { get; set; }
        public DeleteProductModel(IProductData productData)
        {
            this.productData = productData;
        }

        public IActionResult OnGet(int produktId)
        {
            Produkt = productData.GetById(produktId);
            if(Produkt==null)
            {
                RedirectToPage("./ProductsManage");
            };

            return Page();
        }

        public IActionResult OnPost(int produktId)
        {
            var produkt = productData.DeleteProdukt(produktId);
            productData.SaveChanges();
            if (produkt == null)
            {
                RedirectToPage("./NotFound");
            }
            TempData["Message"] = $"{produkt.NazwaProdukt} usunięto";
            return RedirectToPage("./ProductsManage");
        }
    }
}