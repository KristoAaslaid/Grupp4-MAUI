using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp4_MAUI.ViewModel
{
    public class ApiService
    {
        public static async Task<Root> GetWeather(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units=metric&appid=e44051050fea2103eaeca14ebd2f0c14", latitude, longitude));
            return JsonConvert.DeserializeObject<Root>(response);

        }
        public static async Task<Root> GetWeatherByCity(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("", latitude, longitude));
            return JsonConvert.DeserializeObject<Root>(response);

        }
    }
}
