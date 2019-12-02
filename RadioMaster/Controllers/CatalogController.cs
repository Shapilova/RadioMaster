using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RadioMaster.Models;

namespace RadioMaster.Controllers
{
    //Контроллер каталога
    public class CatalogController : Controller
    {
        private int IdFilter //Код фильтрации каталога по категориям
        {
            get { return IdFilter; }

            set
            {
                if (value < 0 || value > CatalogRep.Categories.Count())
                {
                    value = 0;
                }

                IdFilter = value;
            }
        }

        //Отображение каталога
        public IActionResult Index()
        {
            IdFilter = 0;

            ViewBag.ItemType = CatalogRep.Categories;
            return View(CatalogRep.Сatalog);
        }

        //Добавить товар в корзину
        [HttpGet]
        public ViewResult AddItemToCart(int idItem)
        {
            IdFilter = 0;

            ViewBag.ItemType = CatalogRep.Categories;
            return ChooseItemsToShowCatalog();
        }

        //Фильтровать товары по категориям
        [HttpGet]
        public ViewResult FilterCatalog(int idItemType)
        {
            IdFilter = idItemType;

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
                IEnumerable<Item> items = CatalogRep.Сatalog.Where(x => x.ItemTypeId == IdFilter);
                return View("Index", items);
            }
        }
    }
}