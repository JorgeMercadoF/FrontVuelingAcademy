using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FrontVuelingAcademy.Models;
using FrontVuelingAcademy.Repositories;

namespace FrontVuelingAcademy.Controllers
{
    public class ModulosController : Controller
    {
        ModulosRepository db = new ModulosRepository();
        // GET: Modulos
        public async Task<ActionResult> Index()
        {
            return View(await db.GetModulos());
        }

        // GET: Modulos/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await db.GetModulo(id));
        }

        // GET: Modulos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Modulos/Create
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

        // GET: Modulos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Modulos/Edit/5
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

        // GET: Modulos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Modulos/Delete/5
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