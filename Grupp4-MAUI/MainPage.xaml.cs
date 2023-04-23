using Grupp4_MAUI.ViewModel;
using Plugin.Maui.Audio;

namespace Grupp4_MAUI;

public partial class MainPage : ContentPage
{

    public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }

}

