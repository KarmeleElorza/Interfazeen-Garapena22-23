using Newtonsoft.Json;
using Wineshop.Models;

namespace Wineshop.Services
{
    public class ArdoaService : IArdoaService
    {
        private Uri rutaTodos = new Uri("https://localhost:44367/api/Ardoa/");
        public async Task<IList<ArdoaUpeltegi>> GetMota(int id)
        {
            List<ArdoaUpeltegi> ardoaUpeltegiList = new List<ArdoaUpeltegi>();
            Uri rutaUpeltegiak = new Uri(rutaTodos, "Mota/" + id.ToString());
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaUpeltegiak))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ardoaUpeltegiList = JsonConvert.DeserializeObject<List<ArdoaUpeltegi>>(apiResponse);
                }
            }
            return ardoaUpeltegiList;
        }

        /*public async Task<IList<Ardoa>> IArdoaService.GetArdoak(int id)
        {
            List<Ardoa> ardoaList = new List<Ardoa>();
            Uri rutaArdoa= new Uri(rutaTodos, id.ToString());
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaArdoa))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ardoaList = JsonConvert.DeserializeObject<List<Ardoa>>(apiResponse);
                }
            }
            return ardoaList;
        }*/
    }
}
