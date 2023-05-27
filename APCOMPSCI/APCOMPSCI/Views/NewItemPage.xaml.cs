using APCOMPSCI.Models;
using APCOMPSCI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APCOMPSCI.Views
{
    public partial class NewItemPage : ContentPage
    {

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
        public async void Dos_Button(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var url = button.ClassId;
            await Launcher.OpenAsync(url);
        }
        public async void Recycle_Button(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var url = button.ClassId;
            await Launcher.OpenAsync(url);
        }
    }
}