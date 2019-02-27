using FrontVuelingAcademy.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontVuelingAcademy.Repositories
{
    public class CursosRepository : Repository
    {
        public async Task<List<Curso>> GetCursos()
        {
            var oData = JsonConvert.DeserializeObject<ODataResponse<Curso>>(await GetDatos("Curso")).Value;
            var subCategorias = JsonConvert.DeserializeObject<ODataResponse<SubCategoria>>(await GetDatos("SubCategoria")).Value;

            foreach (var item in oData)
            {
                item.SubCategoriaNavigation = subCategorias.Single(s => s.Id == item.SubCategoria);
            }


            return oData;
        }

        public async Task<Curso> GetCurso(int id)
        {
            var cursos = await GetCursos();

            return cursos.Single(c => c.Id == id);
        }

        public async Task<List<Curso>> GetCursosOrdenados()
        {
            var cursos = await GetCursos();

            return cursos.OrderBy(c => c.Curso1).ToList();
        }

        public async Task<List<Curso>> GetCursosBySubCategoria(int id)
        {
            var cursos = await GetCursos();

            return cursos.Where(c => c.SubCategoria == id).ToList();
        }
    }
}
