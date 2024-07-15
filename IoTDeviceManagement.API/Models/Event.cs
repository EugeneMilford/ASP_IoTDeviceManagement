namespace IoTDeviceManagement.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventType { get; set; }
        public DateTime Timestamp { get; set; }
        public int DeviceId { get; set; }
        public Device Device { get; set; }
    }
}
