using Artista.Mobile.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;

namespace Artista.Mobile
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
