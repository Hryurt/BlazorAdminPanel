using System;

namespace RoyalstarAdminPanel.Models
{
    public class Machine
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int DeviceBarcodeNo { get; set; }
        public bool DeviceOnOff { get; set; }
        public int ActivePower { get; set; }
        public int ApparentPower { get; set; }
    }
}