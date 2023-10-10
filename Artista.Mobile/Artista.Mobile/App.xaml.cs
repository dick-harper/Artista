using Artista.Services.Interfaces;
using Artista.Mobile.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Artista.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();

            RegisterServices(serviceCollection);

            RegisterViewModels(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            MainPage = ServiceProvider.GetRequiredService<MainPage>();
        }

        public IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IMuseumService, Services.MuseumService>();
        }

        private void RegisterViewModels(IServiceCollection services)
        {
            services.AddTransient<MainPageViewModel>();            
            services.AddTransient<SearchViewModel>();
            services.AddTransient<HeaderViewModel>();
            services.AddTransient<FooterViewModel>();
            services.AddTransient<MainPage>();
        }
    }
}
