using Grupp4_MAUI.ViewModel;
using System.Collections.ObjectModel;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Newtonsoft.Json;

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
            email = Username.Text,
            password = Password.Text,
        };

        var body = JsonConvert.SerializeObject(details);
        var content = new StringContent(body);

        var httpResponse = await _Client.PostAsync(url, content);

        if (httpResponse.IsSuccessStatusCode)
        {
            Error.Text = "Successfully registered!";
        } else
        {
            Error.Text = httpResponse.Content.ReadAsStringAsync().Result;
        }
    }
    void OnEntryTextChanged(object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        password = Password.Text;
        email = Username.Text;
    }
    public class User
    {

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("password")]
        public string password { get; set; }

    }
}