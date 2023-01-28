using Microsoft.Extensions.Logging;

namespace Artista.Maui;

using CommunityToolkit.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()            
            // Initialize the .NET MAUI Community Toolkit by adding the below line of code
            .UseMauiCommunityToolkit()      
            .RegisterViewModels()
            .RegisterViews()

            // After initializing the .NET MAUI Community Toolkit, optionally add additional fonts
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Continue initializing your .NET MAUI App here
        

        return builder.Build();
    }

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {        
        mauiAppBuilder.Services.AddSingleton<ViewModels.LoginViewModel>();

        //mauiAppBuilder.Services.AddTransient<ViewModels.CheckoutViewModel>();

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<Views.LoginView>();

        //mauiAppBuilder.Services.AddTransient<ViewModels.CheckoutViewModel>();

        return mauiAppBuilder;
    }
}
