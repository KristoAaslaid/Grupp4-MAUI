namespace Grupp4_MAUI.SituationPages;

public partial class Swamp : ContentPage
{
	public Swamp()
	{
		InitializeComponent();
	}
    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}