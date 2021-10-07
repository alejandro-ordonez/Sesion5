using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using Sesion5.Helpers;
using Sesion5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sesion5.Pages
{
    public partial class Page2 : ContentPage
    {
        public List<Monkey> Monkeys { get; set; }
        public Page2()
        {
            InitializeComponent();

            MonkeyList.ItemsSource = MonkeySeeder.GetMonkeys;
            MonkeyList.ItemSelected += MonkeyList_ItemSelected;
        }

        private void MonkeyList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var monkey = e.SelectedItem as Monkey;
            Debug.WriteLine("A monkey was selected!");
            Navigation.PushModalAsync(new MonkeyDetail(monkey));
        }
    }
}
