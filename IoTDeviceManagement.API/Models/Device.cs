namespace IoTDeviceManagement.API.Models
{
    public class Device
    {
        public int DeviceId { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int DeviceTypeId { get; set; }
        public DeviceType DeviceType { get; set; }
        public string FirmwareVersion { get; set; }
        public bool IsOnline { get; set; }
        public DateTime LastOnline { get; set; }
        public string IPAddress { get; set; }
    }
}
