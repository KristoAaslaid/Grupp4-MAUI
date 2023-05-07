namespace Grupp4_MAUI.SensorPages;

public partial class HumiditySensor : ContentPage
{
	public HumiditySensor()
	{
		InitializeComponent();
	}
    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}