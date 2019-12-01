using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RadioMaster.Models;
using System.Diagnostics;

namespace RadioMaster.Controllers
{
    //Контроллер главный страницы
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;   //Логгер

        //Конструктор контроллера
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        //Отображение главной страницы
        public IActionResult Index()
        {
            return View();
        }

        //Отображение страницы конфиденциальности
        public IActionResult Privacy()
        {
            return View();
        }

        //Отображение ошибки
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
