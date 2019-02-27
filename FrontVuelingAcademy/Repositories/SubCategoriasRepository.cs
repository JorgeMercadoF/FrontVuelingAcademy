using FrontVuelingAcademy.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontVuelingAcademy.Repositories
{
    public class SubCategoriasRepository : Repository
    {
        public async Task<List<SubCategoria>> GetSubCategorias()
        {
            var oData = JsonConvert.DeserializeObject<ODataResponse<SubCategoria>>(await GetDatos("SubCategoria")).Value;
            var categorias = JsonConvert.DeserializeObject<ODataResponse<Categoria>>(await GetDatos("Categoria")).Value;

            foreach (var item in oData)
            {
                item.CategoriaNavigation = categorias.Single(c => c.Id == item.Categoria);
            }

            return oData;
        }

        public async Task<SubCategoria> GetSubCategoria(int id)
        {
            var subCategorias = await GetSubCategorias();

            return subCategorias.Where(c => c.Id == id).Single();
        }

        public async Task<List<SubCategoria>> GetSubCategoriasOrdenadas()
        {
            var subCategorias = await GetSubCategorias();

            return subCategorias.OrderBy(c => c.Sub_Categoria).ToList();
        }

        public async Task<List<SubCategoria>> GetSubCategoriasByCategoria(int id)
        {
            var subCategorias = await GetSubCategorias();

            return subCategorias.Where(c => c.Categoria == id).ToList();
        }
    }
}
