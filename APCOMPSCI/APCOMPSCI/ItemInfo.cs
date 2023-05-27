using System;
using System.Collections.Generic;
using System.Text;

namespace APCOMPSCI
{
   public class ItemInfo
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public String Amount { get; set; }
        public ItemInfo(String name, String amount, string description) {
        ItemName= name;
        Amount= amount;
        Description= description;
        }
        public ItemInfo() { }

    }
}
