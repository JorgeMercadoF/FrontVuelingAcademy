using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontVuelingAcademy.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FrontVuelingAcademy.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriasRepository db = new CategoriasRepository();
        SubCategoriasRepository repoSubCategorias = new SubCategoriasRepository();
        // GET: Categorias
        public async Task<ActionResult> Index()
        {
            return View(await db.GetCategorias());
        }

        // GET: Categorias/Details/5
        public async Task<ActionResult> Details(int id)
        {
            ViewData["SubCategorias"] = await repoSubCategorias.GetSubCategoriasByCategoria(id);
            return View(await db.GetCategoria(id));
        }

        // GET: Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
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

        // GET: Categorias/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Categorias/Edit/5
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

        // GET: Categorias/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categorias/Delete/5
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