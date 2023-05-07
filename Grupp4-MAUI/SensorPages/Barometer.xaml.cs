namespace Grupp4_MAUI.SensorPages;

public partial class Barometer : ContentPage
{
	public Barometer()
	{
		InitializeComponent();
	}
    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}