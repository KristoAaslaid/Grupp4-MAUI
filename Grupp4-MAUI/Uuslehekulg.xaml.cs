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

public partial class Uuslehekulg : ContentPage
{
    public Uuslehekulg(UuslehekulgViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }



    private const string url = "https://reqres.in/api/users";
    private HttpClient _Client = new HttpClient();
    private ObservableCollection<User> userCollection;

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        var httpResponse = await _Client.GetAsync(url);

        if (httpResponse.IsSuccessStatusCode)
        {
            Response responseData = JsonConvert.DeserializeObject<Response>(await httpResponse.Content.ReadAsStringAsync());
            userCollection = new ObservableCollection<User>(responseData.Users);
            userList.ItemsSource = userCollection;
        }
    }

    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("avatar")]
        public string AvatarURI { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }

    public class Response
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("data")]
        public ObservableCollection<User> Users { get; set; }
    }
}