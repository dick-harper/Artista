using Artista.Models;
using Artista.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Artista.Services
{
    public class MuseumService : IMuseumService
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public MuseumService()
        {
            _httpClient.BaseAddress = new Uri("https://collectionapi.metmuseum.org");
        }

        public async Task<ArtWork> GetAsync(int objectId)
        {
            var path = $"public/collection/v1/objects/{objectId}";

            using (var response = await _httpClient.GetAsync(path))
            {
                try
                {
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var artModel = JsonConvert.DeserializeObject<ArtWork>(responseBody);
                    return artModel;
                }catch (Exception ex)
                {
                    var msg = ex.Message;
                }

                return null;
            }            
        }
    }
}
