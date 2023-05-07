namespace Grupp4_MAUI.SituationPages;

public partial class Mountain : ContentPage
{
	public Mountain()
	{
		InitializeComponent();
	}
    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}