using Artista.Xam.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;

namespace Artista.Xam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = ((App)Application.Current).ServiceProvider.GetService<MainPageViewModel>();
        }
    }
}
