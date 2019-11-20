using Microsoft.AspNetCore.Mvc;
using RadioMaster.Models;
using System.Collections.Generic;
using System.Linq;

namespace RadioMaster.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View(CartRep.Cart);
        }

        [HttpGet]
        public ViewResult RemoveLineFromCart(int idItem)
        {
            Item item = CatalogRep.Сatalog
                .FirstOrDefault(x => x.Id == idItem);

            CartRep.RemoveLine(item);

            ViewBag.ItemType = CatalogRep.Categories;
            return View("Index", CartRep.Cart);
        }
    }
}