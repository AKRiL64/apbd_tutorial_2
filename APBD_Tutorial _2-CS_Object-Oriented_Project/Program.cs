using System.Numerics;

namespace APBD_Tutorial__2_CS_Object_Oriented_Project;

public static class Program {
    public static void Main(string[] args) {
        DeviceService deviceService = new DeviceService();
        UserService userService = new UserService();
        RentalService rentalService = new RentalService(deviceService, userService);
        
        deviceService.Add(new Laptop("MacBook WOW", "Apple", 2077, 0.4f));
        deviceService.Add(new Camera("Sonya", 999f, new Vector2(2,2), true));
        deviceService.Add(new Projector("IDONTKNOWANY", new Vector2(2,2), 25, -1));
        Console.WriteLine("Added devices:");
        foreach (var device in deviceService.GetAll()) {
            Console.WriteLine(device.Name);
        }
        Console.WriteLine();
        
        userService.Add(new Student("Kenny", "Ohgodtheykilled"));
        userService.Add(new Employee("Sir", "Important"));
        Console.WriteLine("Added users:");
        foreach (var user in userService.GetAll()) {
            Console.WriteLine(user.FirstName + " " + user.LastName);
        }
        
        Rental rental = rentalService.Rent(1, 1, 3);
        Console.WriteLine("Rental of: " + rental.Device.Name);
        
        Console.WriteLine("Now try to rent a device that is unavailable");

        try {
            rental = rentalService.Rent(2, 1, 5);
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
        
        Console.WriteLine();
        
        Console.WriteLine("Returning laptop on time");
        var penalty1 = rental.Return();
        Console.WriteLine($"Penalty: {penalty1}");
        
        Console.WriteLine("Renting camera with late return");
        var rental2 = rentalService.Rent(userId: 2, deviceId: 3, days: -1);
        var penalty2 = rental2.Return();
        Console.WriteLine($"Late return penalty: {penalty2}");
        
        
        Console.WriteLine();
        
        Console.WriteLine("REPORT FINAL:");
        
        Console.WriteLine("Devices:");
        foreach (var device in deviceService.GetAll()) {
            Console.WriteLine($"{device.Id}: {device.Name}, Available: {device.IsAvailable}");
        }
        
        Console.WriteLine("Users:");
        foreach (var user in userService.GetAll())
        {
            Console.WriteLine($"{user.Id}: {user.FirstName} {user.LastName}");
        }
        
        Console.WriteLine("Rentals:");
        foreach (var rentalT in rentalService.GetRentals())
        {
            Console.WriteLine($"User {rentalT.User.FirstName}"+ " + "  + $"{rentalT.Device.Name}");
        }
    }
}