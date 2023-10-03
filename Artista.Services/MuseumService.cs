using Artista.Models;
using Artista.Services.Interfaces;
using Newtonsoft.Json;

namespace Artista.Services
{
    internal class MuseumService : IMuseumService
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public MuseumService()
        {
            _httpClient.BaseAddress = new Uri("https://collectionapi.metmuseum.org");
        }

        public async Task<ArtModel> Get(int objectId)
        {
            var path = $"public/collection/v1/objects/{objectId}";

            using HttpResponseMessage response = await _httpClient.GetAsync(path);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var artModel = JsonConvert.DeserializeObject<ArtModel>(responseBody);
            return artModel;
        }
    }
}
