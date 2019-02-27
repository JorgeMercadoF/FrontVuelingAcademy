using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrontVuelingAcademy.Models;
using FrontVuelingAcademy.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace FrontVuelingAcademy.Controllers
{
    public class HomeController : Controller
    {
        private readonly CategoriasRepository repoCategorias = new CategoriasRepository();
        private readonly SubCategoriasRepository repoSubCategorias = new SubCategoriasRepository();
        private readonly CursosRepository repoCursos = new CursosRepository();

        public async Task<IActionResult> Index()
        {
            var categorias = (await repoCategorias.GetCategoriasOrdenadas());
            HttpContext.Session.Set("Categorias", Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(categorias)));

            var subCategorias = (await repoSubCategorias.GetSubCategoriasOrdenadas());
            HttpContext.Session.Set("SubCategorias", Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(subCategorias)));

            var cursos = (await repoCursos.GetCursosOrdenados());
            HttpContext.Session.Set("Cursos", Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(cursos)));


            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
