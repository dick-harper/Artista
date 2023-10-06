using Artista.Models;
using Artista.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Artista.Xam.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        private readonly IMuseumService _museumService;

        [ObservableProperty]
        private ArtWork _mainArtWork;

        [ObservableProperty]
        private string _title;

        public MainPageViewModel(IMuseumService museumService)
        {
            Title = "Welcome to Artista";
            
            _museumService = museumService;
            
            LoadImage();
        }

        [RelayCommand]
        async Task LoadImage()
        {
            var random = new Random();

            MainArtWork = await _museumService.GetAsync(random.Next(100, 9999));
        }

        [RelayCommand]
        async Task Search()
        {

        }
    }
}
