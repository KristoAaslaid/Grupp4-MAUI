using Grupp4_MAUI.ViewModel;
using Plugin.Maui.Audio;

namespace Grupp4_MAUI;

public partial class MainPage : ContentPage
{
	int count = 0;
    string themeValue = Preferences.Default.Get("themeValue", "Unknown");

    public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
        //Theme of app depending on user preferences
		if (themeValue == "Dark")
		{
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
        else
		{
            Application.Current.UserAppTheme = AppTheme.Light;
        }
    }

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

        var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("button-11.mp3"));

        audioPlayer.Play();
    }

    private void TestValue(object sender, EventArgs e)
    {
        string themeValue = Preferences.Default.Get("themeValue", "Unknown");
        TestBtn.Text = themeValue;

        SemanticScreenReader.Announce(TestBtn.Text);
    }

    public void ToggleAccelerometer(object sender, EventArgs e)
    {
        if (Accelerometer.Default.IsSupported)
        {
            if (!Accelerometer.Default.IsMonitoring)
            {
                // Turn on accelerometer
                Accelerometer.Default.ReadingChanged += Accelerometer_ReadingChanged;
                Accelerometer.Default.Start(SensorSpeed.UI);
                AccelToggle.Text = "Reading";
            }
            else
            {
                // Turn off accelerometer
                Accelerometer.Default.Stop();
                Accelerometer.Default.ReadingChanged -= Accelerometer_ReadingChanged;
                AccelToggle.Text = "Not reading";
            }
        }
    }

    private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
    {
        // Update UI Label with accelerometer state
        AccelText.TextColor = Colors.Green;
        AccelText.Text = $"Accel: {e.Reading}";
    }
}

