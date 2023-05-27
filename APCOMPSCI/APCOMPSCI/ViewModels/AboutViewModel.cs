using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace APCOMPSCI.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.cityofpleasantoncs.gov/recycling/buyback.asp"));
        }

        public ICommand OpenWebCommand { get; }
    }
}