using Microsoft.AspNetCore.Mvc;
using RadioMaster.Models;
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
        public ViewResult AddItemToCart(int id)
        {
            Item item = CatalogRep.Сatalog
                .FirstOrDefault(x => x.Id == id);

            CartRep.AddItem(item);
            return View("Index", CatalogRep.Сatalog);
        }

        [HttpGet]
        public ViewResult RemoveLineFromCart(int id)
        {
            Item item = CatalogRep.Сatalog
                .FirstOrDefault(x => x.Id == id);

            CartRep.RemoveLine(item);
            return View("Cart", CartRep.Cart);
        }
    }
}