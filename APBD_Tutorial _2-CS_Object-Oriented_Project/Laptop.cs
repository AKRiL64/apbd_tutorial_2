namespace APBD_Tutorial__2_CS_Object_Oriented_Project;

public class Laptop: Device {
    
    public float ScreenSizeInches { get; set; }
    public string Brand { get; set; }
    public int Generation { get; set; }
    public Laptop(string name, string brand, int generation, float screenSizeInches) : base(name) {
        ScreenSizeInches = screenSizeInches;
        Brand = brand;
        Generation = generation;
    }
}