namespace Grupp4_MAUI.SensorPages;

public partial class Thermometer : ContentPage
{
	public Thermometer()
	{
		InitializeComponent();
	}
    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}