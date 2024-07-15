namespace IoTDeviceManagement.API.Models
{
    public class UserDevice
    {
        public int UserDeviceId { get; set; }
        public User User { get; set; }
        public int DeviceId { get; set; }
        public Device Device { get; set; }
    }
}
