using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using Sesion5.Models;
using System;

namespace Sesion5.Pages
{
    public partial class MonkeyDetail : ContentPage
    {

        public Monkey Monkey { get; set; }

        public MonkeyDetail(Monkey monkey)
        {
            BindingContext = monkey; ;
            InitializeComponent();
        }
    }
}
