using System.Numerics;

namespace APBD_Tutorial__2_CS_Object_Oriented_Project;

public class Camera: Device {
    public float StorageCapacityMegabytes { get; set; }
    public Vector2 Resolution { get; set; }
    public bool HasSdCardSlot { get; set; }
    
    public Camera(string name, float storageCapacityMegabytes, Vector2 resolution, bool hasSdCardSlot) : base(name) {
        StorageCapacityMegabytes = storageCapacityMegabytes;
        Resolution = resolution;
        HasSdCardSlot = hasSdCardSlot;
    }
    
}