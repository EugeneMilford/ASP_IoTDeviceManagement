namespace IoTDeviceManagement.API.Models
{
    public class Alert
    {
        public int AlertId { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public int DeviceId { get; set; }
        public Device Device { get; set; }
        public bool IsRead { get; set; }
    }
}
