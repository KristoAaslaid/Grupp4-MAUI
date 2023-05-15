using Grupp4_MAUI.ViewModel;
using Plugin.Maui.Audio;

namespace Grupp4_MAUI;

public partial class MainPage : ContentPage
{

    public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }

    // Käsk minna Esmaabi lehele

    private async void NavigateToFirstAid(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FirstAid());
    }

    // Käsk minna Situatsioonide lehele

    private async void NavigateToSituations(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Situations());
    }

    // Käsk minna Kompassi lehele

    private async void NavigateToCompass(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CompassPage());
    }

    // Käsk minna Sensorite lehele

    private async void NavigateToSensors(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sensors());
    }

    // Käsk minna GPS lehele

    private async void NavigateToGPS(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GPS());
    }

    private async void NavigateToWeather(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WeatherPage());
    }

}

