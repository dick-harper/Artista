using Artista.Models;
using System.Threading.Tasks;

namespace Artista.Services.Interfaces
{
    public interface IMuseumService
    {
        Task<ArtWork> GetAsync(int objectId);       
    }
}
