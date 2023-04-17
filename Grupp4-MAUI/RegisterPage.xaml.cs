using Grupp4_MAUI.ViewModel;
using System.Collections.ObjectModel;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text;

namespace Grupp4_MAUI;

public partial class RegisterPage : ContentPage
{
	public RegisterPage(RegisterPageViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }

    private const string url = "https://reqres.in/api/register";
    private HttpClient _Client = new HttpClient();

    string password;
    string email;

    private async void RegisterAccountAsync(object sender, EventArgs e)
    {

        var details = new User()
        {
            email = Email.Text,
            password = Password.Text,
        };

        var body = JsonConvert.SerializeObject(details);
        var content = new StringContent(body, Encoding.UTF8, "application/json");

        var httpResponse = await _Client.PostAsync(url, content);

        if (httpResponse.IsSuccessStatusCode)
        {
            Error.Text = "Successfully registered!";
        } else
        {
            Error.Text = httpResponse.Content.ReadAsStringAsync().Result;
            //Error.Text = body;
        }
    }
    public class User
    {

        [JsonProperty("username")]
        public string username { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("password")]
        public string password { get; set; }

    }
}