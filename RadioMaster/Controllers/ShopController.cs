using Microsoft.AspNetCore.Mvc;
using RadioMaster.Models;

namespace RadioMaster.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        [HttpGet]
        public ViewResult ItemAddToCart()
        {
            return View();
        }
        [HttpPost]
        public ViewResult ItemAddToCart(Item item)
        {
            CartRep.AddItem(item);
            return View("Index");
        }
    }
}