using APCOMPSCI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat;
using Xamarin.Forms.Xaml;

namespace APCOMPSCI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "123")
            Xamarin.Forms.Application.Current.MainPage = new AppShell();
            else
            {
                await DisplayAlert("ERROR", "Username of Password Wrong", "OK");
            }
        
              
            
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
    }
}