namespace Grupp4_MAUI;

public partial class FirstAid : ContentPage
{
	public FirstAid()
	{
		InitializeComponent();
	}

    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}