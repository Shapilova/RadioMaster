using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RadioMaster.Controllers
{
    //Контроллер товаров
    public class ItemController : Controller
    {
        // GET: Item
        //Отображение товаров
        public ActionResult Index()
        {
            return View();
        }

        // GET: Item/Details/5
        //Отображение товара
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Item/Create
        //Добавление товара
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        //Добавление товара. Запрос в базу данных
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Edit/5
        //Изменение товара
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Item/Edit/5
        //Изменение товара. Запрос в базу данных
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Delete/5
        //Удаление товара
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Item/Delete/5
        //Удаление товара. Запрос в базу данных
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}