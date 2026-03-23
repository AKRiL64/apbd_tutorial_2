namespace APBD_Tutorial__2_CS_Object_Oriented_Project;

public class RentalService {
    private readonly DeviceService deviceService;
    private readonly UserService userService;
    private readonly List<Rental> rentals = [];

    public RentalService(DeviceService deviceService, UserService userService) {
        this.deviceService = deviceService;
        this.userService = userService;
    }
    
    public Rental Rent(int userId, int deviceId, int days)
    {
        var user = userService.GetById(userId);
        var device = deviceService.GetById(deviceId);

        if (!device.IsAvailable)
            throw new InvalidOperationException("Device unavailable");

        int activeRentals = rentals.Count(r =>
            r.User == user && r.IsActive());

        if (activeRentals >= user.GetMaxActiveRentals())
            throw new InvalidOperationException("Rental limit exceeded");

        device.SetAvailable();

        var rental = new Rental(user, device, days);
        rentals.Add(rental);

        return rental;
    }
}