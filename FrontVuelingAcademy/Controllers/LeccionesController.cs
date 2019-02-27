using System.Threading.Tasks;
using FrontVuelingAcademy.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontVuelingAcademy.Controllers
{
    public class LeccionesController : Controller
    {
        LeccionesRepository db = new LeccionesRepository();

        // GET: Lecciones
        public async Task<ActionResult> Index()
        {
            return View(await db.GetLecciones());
        }

        // GET: Lecciones/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await db.GetLeccion(id));
        }

        // GET: Lecciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lecciones/Create
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

        // GET: Lecciones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lecciones/Edit/5
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

        // GET: Lecciones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lecciones/Delete/5
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