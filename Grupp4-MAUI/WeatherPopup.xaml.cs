using CommunityToolkit.Maui.Views;
using Grupp4_MAUI.ViewModel;
using System.Collections.ObjectModel;

namespace Grupp4_MAUI;

public partial class WeatherPopup : Popup
{
	private ForecastItem fcitm;
	public WeatherPopup(ForecastItem fc)
	{
		InitializeComponent();
		fcitm = fc;

        // Get forecast data that's passed to the popup and render
        WeatherDescription.Text = fc.weather[0].description;
        TemperatureLabel.Text = fc.main.temperature + "°C";
        HumidityLabel.Text = fc.main.humidity + "%";
        WindLabel.Text = fc.wind.speed + "km/h";
        WeatherImage.Source = fc.weather[0].fullIconUrl;
    }
}