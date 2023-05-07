namespace Grupp4_MAUI.SituationPages;

public partial class Ice : ContentPage
{
	public Ice()
	{
		InitializeComponent();
	}
    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}