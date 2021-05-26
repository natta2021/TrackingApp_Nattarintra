using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingApp_Nattarintra
{
    class Location
    {
        public Location(string shopAddress)
        {
            ShopAddress = shopAddress;
            
        }

        public int Id { get; set; }
        public string ShopAddress { get; set; }
        
        public List<Item> Items { get; set; } // refer to Item class
        public List<Device> Devices { get; set; } // refer to Device class


    }
}
