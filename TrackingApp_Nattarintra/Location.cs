using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingApp_Nattarintra
{
    class Location
    {
        public Location(string shopAddress, int itemId)
        {
            ShopAddress = shopAddress;
            ItemId = itemId;
        }

        public int Id { get; set; }
        public string ShopAddress { get; set; }
        public int ItemId { get; set; }
    }
}
