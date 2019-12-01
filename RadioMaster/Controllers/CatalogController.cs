using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RadioMaster.Models;

namespace RadioMaster.Controllers
{
    //Контроллер каталога
    public class CatalogController : Controller
    {
        public static int IdFilter { get; set; } //Код фильтрации каталога по категориям

        //Отображение каталога
        public IActionResult Index()
        {
            return idFilter;
        }

        //Добавить товар в корзину
        [HttpGet]
        public ViewResult AddItemToCart(int idItem)
        {
            SetIdFilter(0);

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
            ViewBag.ItemType = CatalogRep.Categories;
            if (IdFilter == 0)
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