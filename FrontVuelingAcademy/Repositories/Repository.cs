using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontVuelingAcademy.Repositories
{
    public abstract class Repository
    {
        public static async Task<string> GetDatos(string tabla)
        {
            var httpClient = new HttpClient();
            var url = string.Format(@"https://wcfodatacursosvuelings.azurewebsites.net/AcademiaVueling.svc/{0}?$format=json", tabla);
            var uri = new Uri(url);
            var response = await httpClient.GetAsync(uri);


            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;

            }
            return null;
        }
    }
}
