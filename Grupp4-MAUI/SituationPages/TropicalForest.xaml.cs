namespace Grupp4_MAUI.SituationPages;

public partial class TropicalForest : ContentPage
{
    public TropicalForest()
    {
        InitializeComponent();
    }

    // Tagasi nupu loogika

    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}