using FrontVuelingAcademy.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontVuelingAcademy.Repositories
{
    public class ModulosRepository : Repository
    {
        public async Task<List<Modulo>> GetModulos()
        {
            var oData = JsonConvert.DeserializeObject<ODataResponse<Modulo>>(await GetDatos("Modulo")).Value;
            var lecciones = JsonConvert.DeserializeObject<ODataResponse<Lección>>(await GetDatos("Lección")).Value;

            foreach (var item in oData)
            {
                item.Lección = lecciones.Where(l => l.Modulo == item.Id).ToList();
            }

            return oData;
        }

        public async Task<Modulo> GetModulo(int id)
        {
            var modulos = await GetModulos();

            return modulos.Single(c => c.Id == id);
        }

        public async Task<List<Modulo>> GetModulosOrdenados()
        {
            var modulos = await GetModulos();

            return modulos.OrderBy(c => c.Modulo1).ToList();
        }

        public async Task<List<Modulo>> GetModulosByCurso(int id)
        {
            var modulos = await GetModulos();

            return modulos.Where(c => c.Curso == id).ToList();
        }
    }
}
