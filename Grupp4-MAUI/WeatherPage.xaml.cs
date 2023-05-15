using Grupp4_MAUI.ViewModel;

namespace Grupp4_MAUI;

public partial class WeatherPage : ContentPage
{
	private double latitude;
	private double longitude;
	public WeatherPage()
	{
		InitializeComponent();
	}
	// Get the current weather when the page appears
	protected async override void OnAppearing()
	{
        base.OnAppearing();
		await GetLocation();
		// Get the current weather
		var result = await ApiService.GetWeather(latitude, longitude);
		// Set labels to the current weather
		LocationName.Text = result.name;
		WeatherDescription.Text = result.weather[0].description;
		TemperatureLabel.Text = result.main.temperature + "°C";
        HumidityLabel.Text = result.main.humidity + "%";
        WindLabel.Text = result.wind.speed + "km/h";
        WeatherImage.Source = result.weather[0].fullIconUrl;
    }
	// Get the current location of the device
	public async Task GetLocation()
	{
		var location = await Geolocation.GetLocationAsync();
		latitude = location.Latitude;
		longitude = location.Longitude;
	}
    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}