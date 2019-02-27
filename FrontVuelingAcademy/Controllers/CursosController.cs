using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontVuelingAcademy.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontVuelingAcademy.Controllers
{
    public class CursosController : Controller
    {
        CursosRepository db = new CursosRepository();
        ModulosRepository repoModulos = new ModulosRepository();

        // GET: Cursos
        public async Task<ActionResult> Index()
        {
            return View(await db.GetCursos());
        }

        // GET: Cursos/Details/5
        public async Task<ActionResult> Details(int id)
        {
            ViewData["Modulos"] = await repoModulos.GetModulosByCurso(id);
            return View(await db.GetCurso(id));
        }

        // GET: Cursos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cursos/Create
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

        // GET: Cursos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cursos/Edit/5
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

        // GET: Cursos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cursos/Delete/5
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