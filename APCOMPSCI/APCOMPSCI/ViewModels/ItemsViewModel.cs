using APCOMPSCI.Models;
using APCOMPSCI.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace APCOMPSCI.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ICommand AddItemCommand => new Command(AddItem);
        public ICommand RemoveItemCommand => new Command(RemoveItem);
        public ObservableCollection<ItemInfo> Items { get; set; }
        public string ItemName { get; set; }
        public ItemInfo GetItem { get; set; }
        public string ItemDescription { get; set; }
        public String ItemAmount { get; set; }
        public ItemInfo SelectedItem { get; set; }


        public ItemsViewModel()
        {
           Items= new ObservableCollection<ItemInfo>();

            MessagingCenter.Subscribe<ItemDetailPage, ItemInfo>(this, "ItemDetailPage", (page, item) =>
            {
                if (item.Amount == "")
                {
                    Items.Add(item);
                }
                else
                {
                    ItemInfo itemToEdit = Items.Where(itm => itm.Amount == item.Amount).FirstOrDefault();
                    int newIndex = Items.IndexOf(itemToEdit);
                    Items.Remove(itemToEdit);

                    Items.Add(item);
                    int oldIndex = Items.IndexOf(item);
                    
                    Items.Move(oldIndex, newIndex);
                }
                    
            });

        }

        public void AddItem()
        {
            Items.Add(new ItemInfo(ItemName, ItemAmount, ItemDescription));
        }
        public void RemoveItem()
        {
            Items.Remove(SelectedItem);
        }
        

    }
}