using CommunityToolkit.Maui.Storage;
using Grupp4_MAUI.ViewModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CommunityToolkit.Maui.Alerts;
using System.Text.Json;
using System.IO;
using Microsoft.Maui.Media;

namespace Grupp4_MAUI;

public partial class SecondPage : ContentPage
{
	public SecondPage(SecondPageViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
	}

}