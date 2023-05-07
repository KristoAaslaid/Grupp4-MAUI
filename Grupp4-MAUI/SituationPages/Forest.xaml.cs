namespace Grupp4_MAUI.SituationPages;

public partial class Forest : ContentPage
{
	public Forest()
	{
		InitializeComponent();
	}
    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}