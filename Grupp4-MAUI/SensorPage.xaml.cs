using Grupp4_MAUI.ViewModel;

namespace Grupp4_MAUI;

public partial class SensorPage : ContentPage
{
	public SensorPage(SensorPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}