namespace Grupp4_MAUI.SensorPages;

public partial class StepDetector : ContentPage
{
	public StepDetector()
	{
		InitializeComponent();
	}
    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}