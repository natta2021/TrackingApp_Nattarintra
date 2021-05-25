using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingApp_Nattarintra
{
    class Item
    {
        public Item(string itemName, int price, DateTime purchasedate, int addressId)
        {
            ItemName = itemName;
            Price = price;
            Purchasedate = purchasedate;
            AddressId = addressId;
        }

        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public DateTime Purchasedate { get; set; }
        public int AddressId { get; set; }
    }
}
