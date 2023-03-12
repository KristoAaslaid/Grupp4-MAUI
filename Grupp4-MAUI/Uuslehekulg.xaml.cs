using Grupp4_MAUI.ViewModel;

namespace Grupp4_MAUI;

public partial class Uuslehekulg : ContentPage
{
	public Uuslehekulg(UuslehekulgViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}