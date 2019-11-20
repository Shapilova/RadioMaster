using Microsoft.AspNetCore.Mvc;
using RadioMaster.Models;
using System.Collections.Generic;
using System.Linq;

namespace RadioMaster.Controllers
{
    public class CatalogController : Controller
    {
        public static int IdFilter { get; set; } //Код фильтрации каталога по категориям

        public IActionResult Index()
        {
            ViewBag.ItemType = CatalogRep.Categories;
            return View(CatalogRep.Сatalog);
        }

        [HttpGet]
        public ViewResult AddItemToCart(int idItem)
        {
            Item item = CatalogRep.Сatalog
                .FirstOrDefault(x => x.Id == idItem);

            CartRep.AddItem(item);

            ViewBag.ItemType = CatalogRep.Categories;
            return ChooseItemsToShowCatalog();
        }

        [HttpGet]
        public ViewResult FilterCatalog(int idItemType)
        {
            IdFilter = idItemType;

            ViewBag.ItemType = CatalogRep.Categories;
            return ChooseItemsToShowCatalog();
        }

        private ViewResult ChooseItemsToShowCatalog()
        {
            ViewBag.ItemType = CatalogRep.Categories;
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