using FrontVuelingAcademy.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontVuelingAcademy.Repositories
{
    public class LeccionesRepository : Repository
    {
        public async Task<List<Lección>> GetLecciones()
        {
            var oData = JsonConvert.DeserializeObject<ODataResponse<Lección>>(await GetDatos("Lección"));

            return oData.Value;
        }

        public async Task<Lección> GetLeccion(int id)
        {
            var lecciones = await GetLecciones();

            return lecciones.Where(c => c.Id == id).Single();
        }

        public async Task<List<Lección>> GetLeccionesOrdenadas()
        {
            var lecciones = await GetLecciones();

            return lecciones.OrderBy(c => c.Lección1).ToList();
        }
    }
}
