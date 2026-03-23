namespace APBD_Tutorial__2_CS_Object_Oriented_Project;

public abstract class Device {
    private static int _id = 1;
    
    public int Id { get; }
    public string Name { get; set; }
    public bool IsAvailable { get; private set; }
    
    public Device(String name) {
        Id = _id++;
        IsAvailable = true;
        Name = name;
    }

    public void SetAvailable() {
        IsAvailable = true;
    }
    public void SetUnavailable() {
        IsAvailable = false;
    }
}