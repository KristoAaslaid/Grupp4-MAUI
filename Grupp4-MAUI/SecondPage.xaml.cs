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
    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
	public SecondPage(SecondPageViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
	}

    AppTheme currentTheme = Application.Current.RequestedTheme;
    private void DarkMode(object sender, EventArgs e)
    {
        if (currentTheme == AppTheme.Light)
        {
            currentTheme = AppTheme.Dark;
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
        else
        {
            currentTheme = AppTheme.Light;
            Application.Current.UserAppTheme = AppTheme.Light;
        }
    }

    private async void SaveText(object sender, EventArgs e)
    {
        using var stream = new MemoryStream(Encoding.Default.GetBytes($"{TextToSave.Text}"));
        var path = await FileSaver.Default.SaveAsync("test.txt", stream, cancellationTokenSource.Token);
        if (path.IsSuccessful)
        {
            await Toast.Make($"The file was saved successfully to location: {path.FilePath}").Show(cancellationTokenSource.Token);
        }
        else
        {
            await Toast.Make($"The file was not saved successfully with error: {path.Exception.Message}").Show(cancellationTokenSource.Token);
        }
    }

    private async void ReadText(object sender, EventArgs e) //Saab valida, aga rohkem ei tee
    {
        var result = await FilePicker.Default.PickAsync(new PickOptions
        {
            PickerTitle = "Pick something"
        });

        if (result == null)
            return;

        var stream = await result.OpenReadAsync();

    }
    async void TakeVideo(object sender, EventArgs e)
    {
        if (MediaPicker.Default.IsCaptureSupported)
        {
            FileResult video = await MediaPicker.Default.CaptureVideoAsync();

            if (video != null)
            {
                // save the file into local storage where the user wants
                var path = await FileSaver.Default.SaveAsync(video.FileName, video.OpenReadAsync().Result, cancellationTokenSource.Token);
                if (path.IsSuccessful)
                {
                    await Toast.Make($"The file was saved successfully to location: {path.FilePath}").Show(cancellationTokenSource.Token);
                }
                else
                {
                    await Toast.Make($"The file was not saved successfully with error: {path.Exception.Message}").Show(cancellationTokenSource.Token);
                }
            }
        }
    }
}