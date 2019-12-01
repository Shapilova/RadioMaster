using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RadioMaster.Models;

namespace RadioMaster.Controllers
{
    //Контроллер каталога
    public class CatalogController : Controller
    {
        private static int idFilter;

        public static int GetIdFilter()
        {
            return idFilter;
        }

        public static void SetIdFilter(int value)
        {
            idFilter = value;
        }

        //Отображение каталога
        public IActionResult Index()
        {
            SetIdFilter(0);

            ViewBag.ItemType = CatalogRep.Categories;
            return View(CatalogRep.Сatalog);
        }

        //Добавить товар в корзину
        [HttpGet]
        public ViewResult AddItemToCart(int idItem)
        {
            Item item = CatalogRep.Сatalog
                .FirstOrDefault(x => x.Id == idItem);

            CartRep.AddItem(item);

            ViewBag.ItemType = CatalogRep.Categories;
            return ChooseItemsToShowCatalog();
        }

        //Фильтровать товары по категориям
        [HttpGet]
        public ViewResult FilterCatalog(int idItemType)
        {
            SetIdFilter(idItemType);

            ViewBag.ItemType = CatalogRep.Categories;
            return ChooseItemsToShowCatalog();
        }

        //Выбрать товары для отображения в каталоге
        private ViewResult ChooseItemsToShowCatalog()
        {
            if (GetIdFilter() == 0)
            {
                return View("Index", CatalogRep.Сatalog);
            }
            else
            {
                IEnumerable<Item> items = CatalogRep.Сatalog.Where(x => x.ItemTypeId == GetIdFilter());
                return View("Index", items);
            }
        }
    }
}