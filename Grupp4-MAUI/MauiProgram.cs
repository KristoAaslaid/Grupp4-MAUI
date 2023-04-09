using Grupp4_MAUI.ViewModel;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace Grupp4_MAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            // Initialize the .NET MAUI Community Toolkit by adding the below line of code
            .UseMauiCommunityToolkit()
            // After initializing the .NET MAUI Community Toolkit, optionally add additional fonts
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        //Meie lisatud osa
        builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddTransient<Uuslehekulg>(); //AddTransient uute lehekülgede puhul
        builder.Services.AddTransient<UuslehekulgViewModel>();

        builder.Services.AddTransient<SecondPage>();
        builder.Services.AddTransient<SecondPageViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
