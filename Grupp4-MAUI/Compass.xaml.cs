namespace Grupp4_MAUI;

public partial class Compass : ContentPage
{
	public Compass()
	{
		InitializeComponent();
	}

    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}