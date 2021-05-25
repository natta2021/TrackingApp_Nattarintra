using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingApp_Nattarintra
{
    class Device
    {
        public Device(string deviceCategory, int itemId)
        {
            DeviceCategory = deviceCategory;
            ItemId = itemId;
        }

        public int Id { get; set; }
        public string DeviceCategory { get; set; }
        public int ItemId { get; set; }
    }
}
