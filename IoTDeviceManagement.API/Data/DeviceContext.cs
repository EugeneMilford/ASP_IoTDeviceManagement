using System.Collections.Generic;
using IoTDeviceManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IoTDeviceManagement.API.Data
{
    public class DeviceContext : DbContext
    {
        public DeviceContext(DbContextOptions<DeviceContext> options) : base(options)
        {
        }

        public DbSet<Device> device { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<Alert> alert { get; set; }
        public DbSet<UserDevice> userDevice { get; set; }
        public DbSet<DeviceType> deviceType { get; set; }
    }
}
