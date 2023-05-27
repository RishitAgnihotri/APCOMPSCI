using APCOMPSCI.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace APCOMPSCI.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage(ItemInfo item = null)
        {
            InitializeComponent();
            if(item != null)
            {
                ((ItemDetailViewModel)BindingContext).Item = item;
            }
        }
        public void Save_Button(object sender, EventArgs e)
        {
            ItemInfo item = ((ItemDetailViewModel)BindingContext).Item;
            Xamarin.Forms.Application.Current.MainPage = new ItemsPage();
        }
    }
}