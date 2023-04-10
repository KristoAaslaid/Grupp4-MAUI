using Grupp4_MAUI.ViewModel;

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

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void TestValue(object sender, EventArgs e)
    {
        string themeValue = Preferences.Default.Get("themeValue", "Unknown");
        TestBtn.Text = themeValue;

        SemanticScreenReader.Announce(TestBtn.Text);
    }

}

