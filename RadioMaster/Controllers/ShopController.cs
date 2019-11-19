using Microsoft.AspNetCore.Mvc;
using RadioMaster.Models;
using System.Collections.Generic;
using System.Linq;

namespace RadioMaster.Controllers
{
    public class ShopController : Controller
    {
        public static int IdFilter { get; set; } //Код фильтрации каталога

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
            return ShowCatalog();
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
        public ViewResult FilterCatalog(int idItemType)
        {
            IdFilter = idItemType;

            ViewBag.ItemType = CatalogRep.Categories;
            return ShowCatalog();
        }

        private ViewResult ShowCatalog()
        {
            if (IdFilter == 0)
            {
                return View("Index", CatalogRep.Сatalog);
            }
            else
            {
                IEnumerable<Item> items = CatalogRep.Сatalog.Where(x => x.ItemTypeId == IdFilter);
                return View("Index", items);
            }
        }
    }
}