namespace IoTDeviceManagement.API.Models
{
    public class DeviceType
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Manufacturer { get; set; }
        public string ModelNumber { get; set; }
        public ICollection<Device> Devices { get; set; }
    }
}
