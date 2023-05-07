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

    private async void NavigateToSensors(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sensors());
    }

}

