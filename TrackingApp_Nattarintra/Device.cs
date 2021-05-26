using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingApp_Nattarintra
{
    class Device
    {
        public Device(string deviceCategory)
        {
            DeviceCategory = deviceCategory;
           
        }

        public int Id { get; set; }
        public string DeviceCategory { get; set; }
        public int AddressId { get; set; } // Shop / Address Id
        public Location Location { get; set; } // Refer to Location class
    }
}
