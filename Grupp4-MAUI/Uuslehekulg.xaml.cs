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
}