using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;
using System.Diagnostics;

namespace Sesion5
{
    public partial class MainPage : ContentPage
    { 

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Button Clicked, navigating to page 2");
            await Navigation.PushAsync(new Pages.Tabbed());

        }

    }
}
