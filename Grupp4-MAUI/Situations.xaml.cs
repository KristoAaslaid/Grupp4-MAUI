using Grupp4_MAUI.SituationPages;

namespace Grupp4_MAUI;

public partial class Situations : ContentPage
{
    public Situations()
    {
        InitializeComponent();
    }
    private async void NavigateToForest(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Forest());
    }
    private async void NavigateToIce(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Ice());
    }
    private async void NavigateToSwamp(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Swamp());
    }
    private async void NavigateToMountain(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Mountain());

    }
    private async void NavigateToTemperateForest(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TemperateForest());
    }
    private async void NavigateToTropicalForest(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TropicalForest());
    }

    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

}