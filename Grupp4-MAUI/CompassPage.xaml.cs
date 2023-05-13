using Microsoft.Maui.Devices.Sensors;

namespace Grupp4_MAUI;

public partial class CompassPage : ContentPage
{
	public CompassPage()
	{
		InitializeComponent();
        if (Compass.Default.IsSupported)
        {
                // Turn on compass
                Compass.Default.ReadingChanged += Compass_ReadingChanged;
                Compass.Default.Start(SensorSpeed.UI);
        }
    }

    private void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
    {
        // Update UI Label with compass state
        CompassLabel.TextColor = Colors.Green;
        CompassLabel.Text = $"{String.Format("{0:0.00}",e.Reading.HeadingMagneticNorth)}°";
        // Rotate compass image to match compass state
        CompassImage.Rotation = e.Reading.HeadingMagneticNorth;
    }

    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
        // Turn off compass
        if (Compass.Default.IsSupported)
        {
            Compass.Default.Stop();
            Compass.Default.ReadingChanged -= Compass_ReadingChanged;
        }
    }
}