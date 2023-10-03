using Artista.Models;

namespace Artista.Services.Interfaces
{
    public interface IMuseumService
    {
        Task<ArtModel> Get(int objectId);
    }
}
