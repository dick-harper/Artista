using Artista.Models;
using Artista.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace Artista.Xam.ViewModels
{
    public partial class SearchViewModel : ObservableObject
    {

        private readonly IMuseumService artService;

        public SearchViewModel(IMuseumService artService)
        {
            this.artService = artService;
        }

        [ObservableProperty]
        private ArtWork _artModel;
        

        [RelayCommand]
        async Task Search()
        {

        }
    }
}
