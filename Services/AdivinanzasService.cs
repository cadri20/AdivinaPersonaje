using AdivinaPersonaje.Model;
using System.Net.Http.Json;

namespace AdivinaPersonaje.Services
{
    public interface IAdivinanzasService
    {
        Task<Adivinanza?> GetAdivinanza(int id);
    }

    public class AdivinanzasService(HttpClient httpClient) : IAdivinanzasService
    {
        private readonly HttpClient _httpClient = httpClient;

        private List<Adivinanza>? adivinanzas;
        public async Task<Adivinanza?> GetAdivinanza(int id)
        {
            if(adivinanzas == null)
            {
                adivinanzas = await _httpClient.GetFromJsonAsync<List<Adivinanza>>("adivinanzas.json");
            }

            return adivinanzas?.Find(a => a.Id == id);
        }

    }
}
