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
    public partial class MainViewModel : ObservableObject
    {

        public MainViewModel()
        {

        }
        // Old unnecessary methods for this project
        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task GoToSensors()
        {
            await Shell.Current.GoToAsync("Sensors");
        }

    }
}
