using System;

namespace RoyalstarAdminPanel.Models
{
    public class MainMachine
    {
        public Guid Id { get; set; }
        public int DeviceBarcodeNo { get; set; }
        public int MainsActivePower { get; set; }
        public int MainsApparentPower { get; set; }
        public int MainsCurrent { get; set; }
        public bool MainsDeviceOnOff { get; set; }
        public int MainsFrequence { get; set; }
        public bool MainsBreakerOff { get; set; }
        public bool MainsBreakerOn { get; set; }
        public bool MainsModeManuel { get; set; }
        public bool MainsModeSemi { get; set; }
        public bool MainsStatusOff { get; set; }
        public bool MainsStatusOn { get; set; }
        public int MainsReactivePower { get; set; }
        public int MainsVolt { get; set; }
        public bool WriteCommand { get; set; }
        public int deviceAdded { get; set; }
    }
}