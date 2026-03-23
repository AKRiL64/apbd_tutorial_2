namespace APBD_Tutorial__2_CS_Object_Oriented_Project;

public class DeviceService
{
    private readonly List<Device> devices = [];

    public void Add(Device device) {
        devices.Add(device);
    }

    public Device GetById(int id) {
        return devices.Single(d => d.Id == id);
    }

    public IEnumerable<Device> GetAll() {
        return devices;
    }

    public IEnumerable<Device> GetAvailable() {
        return devices.Where(d => d.IsAvailable);
    }
    
    public void MarkUnavailable(int deviceId)
    {
        GetById(deviceId).SetUnavailable();
    }
}