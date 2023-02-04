using LinkedGatesTask.Models;
using TaskDB;

namespace LinkedGatesTask.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly Context context;
        public DeviceService(Context context)
        {
            this.context = context;
        }

        public void Add(PropertyValuesVM model)
        {
            
            Device device = new Device();
            device.CategoryId = model.CategoryId;
            device.AcquisitionDate = model.DeviceAcquisitionDate;
            device.Name = model.DeviceName;
            device.memo = model.DeviceMemo;
          //  device.PropertiesValues = model.Values;

            context.Devices.Add(device);
            context.SaveChanges();
            foreach (var item in model.Values)
            {
                item.CategoryId = model.CategoryId;
                item.DeviceId = device.Id;
               


            }
            context.PropertiesValues.AddRange(model.Values);
            context.SaveChanges();

            //context.AddRange(model.Values);


        }
    }
}
