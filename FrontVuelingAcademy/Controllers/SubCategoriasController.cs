using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontVuelingAcademy.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontVuelingAcademy.Controllers
{
    public class SubCategoriasController : Controller
    {
        SubCategoriasRepository db = new SubCategoriasRepository();
        CursosRepository repoCursos = new CursosRepository();

        // GET: SubCategorias
        public async Task<ActionResult> Index()
        {
            return View(await db.GetSubCategorias());
        }

        // GET: SubCategorias/Details/5
        public async Task<ActionResult> Details(int id)
        {
            ViewData["Cursos"] = await repoCursos.GetCursosBySubCategoria(id);
            return View(await db.GetSubCategoria(id));
        }

        // GET: SubCategorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubCategorias/Create
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

        // GET: SubCategorias/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubCategorias/Edit/5
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

        // GET: SubCategorias/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubCategorias/Delete/5
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