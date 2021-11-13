using System.ComponentModel.DataAnnotations;

namespace AdminPanel.Dtos
{
    public class MainMachineBindingModel
    {
        [Required]
        public string DeviceBarcodeNo { get; set; }
        [Required]
        public string MainsActivePower { get; set; }
        [Required]
        public string MainsApparentPower { get; set; }
        [Required]
        public string MainsCurrent { get; set; }
        [Required]
        public bool MainsDeviceOnOff { get; set; }
        [Required]
        public string MainsFrequence { get; set; }
        [Required]
        public bool MainsBreakerOff { get; set; }
        [Required]
        public bool MainsBreakerOn { get; set; }
        [Required]
        public bool MainsModeManuel { get; set; }
        [Required]
        public bool MainsModeSemi { get; set; }
        [Required]
        public bool MainsStatusOff { get; set; }
        [Required]
        public bool MainsStatusOn { get; set; }
        [Required]
        public string MainsReactivePower { get; set; }
        [Required]
        public string MainsVolt { get; set; }
        [Required]
        public bool WriteCommand { get; set; }
        [Required]
        public string deviceAdded { get; set; }
    }
}