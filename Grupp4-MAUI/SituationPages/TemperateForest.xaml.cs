namespace Grupp4_MAUI.SituationPages;

public partial class TemperateForest : ContentPage
{
	public TemperateForest()
	{
		InitializeComponent();
	}

    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

}