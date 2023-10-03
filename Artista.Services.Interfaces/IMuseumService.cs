using Artista.Models;
using System.Threading.Tasks;

namespace Artista.Services.Interfaces
{
    public interface IMuseumService
    {
        Task<ArtModel> Get(int objectId);
    }
}
