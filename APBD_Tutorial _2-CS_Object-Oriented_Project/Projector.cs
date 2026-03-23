using System.Numerics;

namespace APBD_Tutorial__2_CS_Object_Oriented_Project;

public class Projector: Device {
    public Vector2 Resolution { get; set; }
    public int RefreshRate { get; set; }
    public float BatteryLifeMinutes { get; set; }
    
    public Projector(string name, Vector2 resolution, int refreshRate, float batteryLifeMinutes) : base(name) {
        Resolution = resolution;
        RefreshRate = refreshRate;
        BatteryLifeMinutes = batteryLifeMinutes;
    }
}

