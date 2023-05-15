using Grupp4_MAUI.ViewModel;

namespace Grupp4_MAUI;

public partial class MainPage : ContentPage
{

    public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }

    // Functions to navigate to the different pages

    private async void NavigateToFirstAid(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FirstAid());
    }

    private async void NavigateToSituations(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Situations());
    }

    private async void NavigateToCompass(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CompassPage());
    }

    private async void NavigateToGPS(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GPS());
    }

    private async void NavigateToWeather(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WeatherPage());
    }

}

