using Grupp4_MAUI.ViewModel;

namespace Grupp4_MAUI;

public partial class SensorPage : ContentPage
{
	public SensorPage(SensorPageViewModel vm)
	{
		InitializeComponent();
        Shell.Current.DisplayAlert("Orientation", DeviceDisplay.Current.MainDisplayInfo.Orientation.ToString(), "Ok");
        BindingContext = vm;
	}

    private void OnSensorCounterClicked(object sender, EventArgs e)
    {
        Shell.Current.DisplayAlert("Orientation", DeviceDisplay.Current.MainDisplayInfo.Orientation.ToString(), "Ok");
    }
}