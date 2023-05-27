using APCOMPSCI.Models;
using APCOMPSCI.ViewModels;
using APCOMPSCI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace APCOMPSCI.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;
        protected String PhotoPath { get; set; }

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = new ItemsViewModel();
        }
        public void ToolBarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ItemDetailPage());
        }
        async Task TakePhotoAsync()
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                await LoadPhotoAsync(photo);
                Console.WriteLine($"CapturePhotoAsync COMPLETED: {PhotoPath}");
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature is not supported on the device
            }
            catch (PermissionException pEx)
            {
                // Permissions not granted
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CapturePhotoAsync THREW: {ex.Message}");
            }
        }

        async Task LoadPhotoAsync(FileResult photo)
        {
            // canceled
            if (photo == null)
            {
                PhotoPath = null;
                return;
            }
            // save the file into local storage
            var newFile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
            using (var stream = await photo.OpenReadAsync())
            using (var newStream = File.OpenWrite(newFile))
                await stream.CopyToAsync(newStream);

            PhotoPath = newFile;
        }
        private async void BtnTakePhoto_Clicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await TakePhotoAsync();
                resultPhoto.Source = ImageSource.FromFile(PhotoPath);
            });
            

        }
    }
}