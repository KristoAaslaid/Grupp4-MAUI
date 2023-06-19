using CommunityToolkit.Maui.Views;
using Grupp4_MAUI.ViewModel;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Grupp4_MAUI;

public partial class WeatherPage : ContentPage
{
	private double latitude;
	private double longitude;
	private Forecast forecastData;
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

        // Get forecast data
        forecastData = await ApiService.GetForecast(latitude, longitude);
		// Pass the collection made from the data as the item source of our listview
        forecastList.ItemsSource = new ObservableCollection<ForecastItem>(forecastData.list);
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

	// When one of the list items is tapped, compare the time with every element in our saved forecast data
	// When found, create a popup and pass the forecast data as an argument
	private void OnForecastPressed(object sender, EventArgs e)
	{
		var time = (sender as ImageCell).Detail;
		ForecastItem foundItem = new ForecastItem();

		foreach (var forecastItem in forecastData.list)
		{
			var fcTag = forecastItem.time;
			foundItem = forecastItem;
			if (time == fcTag)
			{
				foundItem = forecastItem;
				break;
			}
		}
		// Show the popup :)
		this.ShowPopup(new WeatherPopup(foundItem));
	}
}