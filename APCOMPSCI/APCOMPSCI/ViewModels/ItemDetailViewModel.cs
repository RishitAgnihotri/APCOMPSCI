using APCOMPSCI.Models;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APCOMPSCI.ViewModels
{
    public class ItemDetailViewModel : INotifyPropertyChanged

    {
        private ItemInfo _item;
        public ItemInfo Item {
            get { return _item; }
            set { _item = value; }
        }  
        public ItemDetailViewModel() {
            Item = new ItemInfo();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

