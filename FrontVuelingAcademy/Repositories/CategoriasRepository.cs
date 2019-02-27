using FrontVuelingAcademy.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontVuelingAcademy.Repositories
{
    public class CategoriasRepository : Repository
    {
        public async Task<List<Categoria>> GetCategorias()
        {
            var oData = JsonConvert.DeserializeObject<ODataResponse<Categoria>>(await GetDatos("Categoria"));

            return oData.Value;
        }

        public async Task<Categoria> GetCategoria(int id)
        {
            var categorias = await GetCategorias();

            return categorias.Where(c => c.Id == id).Single();
        }

        public async Task<List<Categoria>> GetCategoriasOrdenadas()
        {
            var categorias = await GetCategorias();

            return categorias.OrderBy(c => c.Categoria1).ToList();
        }
    }
}
