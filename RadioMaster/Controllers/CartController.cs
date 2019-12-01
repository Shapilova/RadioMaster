using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RadioMaster.Models;

namespace RadioMaster.Controllers
{
    //Контроллер корзины
    public class CartController : Controller
    {
        //Отобразить корзину
        public IActionResult Index()
        {
            return View(CartRep.Cart);
        }

        //Убрать позицию из корзины
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