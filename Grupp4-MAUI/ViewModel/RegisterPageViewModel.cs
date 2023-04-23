using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp4_MAUI.ViewModel
{
    [QueryProperty("Text", "Text")] //MainViewModel'ist võtame Tap käsust teksti "Text" ja lisame uuele leheküljele nimega "Text"
    public partial class RegisterPageViewModel : ObservableObject
    {

        [ObservableProperty] // See veel lisada juurde bindimiseks
        string text;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

    }
}