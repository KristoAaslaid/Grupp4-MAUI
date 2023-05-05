using Grupp4_MAUI.SensorPages;

namespace Grupp4_MAUI;

public partial class Sensors : ContentPage
{
	public Sensors()
	{
		InitializeComponent();
	}

    private async void NavigateToThermometer(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Thermometer());
    }
    private async void NavigateToAccelerometer(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SensorPages.Accelerometer());
    }
    private async void NavigateToBarometer(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SensorPages.Barometer());
    }
    private async void NavigateToHumiditySensor(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HumiditySensor());
    }
    private async void NavigateToStepDetector(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StepDetector());
    }

}