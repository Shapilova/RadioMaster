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
            ViewBag.ItemType = CatalogRep.Categories;
            return View(CatalogRep.Сatalog);
        }

        public IActionResult Cart()
        {
            return View(CartRep.Cart);
        }

        [HttpGet]
        public ViewResult AddItemToCart(int idItem)
        {
            Item item = CatalogRep.Сatalog
                .FirstOrDefault(x => x.Id == idItem);

            CartRep.AddItem(item);

            ViewBag.ItemType = CatalogRep.Categories;
            return View("Index", CatalogRep.Сatalog);
        }

        [HttpGet]
        public ViewResult RemoveLineFromCart(int idItem)
        {
            Item item = CatalogRep.Сatalog
                .FirstOrDefault(x => x.Id == idItem);

            CartRep.RemoveLine(item);

            ViewBag.ItemType = CatalogRep.Categories;
            return View("Cart", CartRep.Cart);
        }

        [HttpGet]
        public ViewResult FilterCatalog(int id)
        {
            IEnumerable<Item> items = CatalogRep.Сatalog.Where(x => x.ItemTypeId == id);

            ViewBag.ItemType = CatalogRep.Categories;
            return View("Index", items);
        }
    }
}