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

        [ObservableProperty]
        ObservableCollection<string> _items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {

        }

        [RelayCommand]
        void Delete(string s)
        {

        }

        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(Uuslehekulg)}?Text={s}");
        }

        [RelayCommand]
        async Task NewPage()
        {
            await Shell.Current.GoToAsync(nameof(SecondPage));
        }

        [RelayCommand]
        async Task GoToRegister()
        {
            await Shell.Current.GoToAsync(nameof(RegisterPage));
        }
    }
}
