namespace Grupp4_MAUI.SensorPages;

public partial class Accelerometer : ContentPage
{
	public Accelerometer()
	{
		InitializeComponent();
	}
    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}