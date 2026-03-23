namespace APBD_Tutorial__2_CS_Object_Oriented_Project;

public class Rental {
    private const float RENTAL_PENALTY_PER_DAY = 100f;
    public User User { get; }
    public Device Device { get; }
    public DateTime StartDate { get; }
    public DateTime EndDate { get; }
    public DateTime? ReturnDate { get; private set; }
    
    public Rental(User user, Device device, int days) {
        User = user;
        Device = device;
        StartDate = DateTime.Now;
        EndDate = StartDate.AddDays(days);
    }
    
    public bool IsActive() {
        return ReturnDate == null;
    }
    
    public float Return() {
        ReturnDate = DateTime.Now;
        Device.SetAvailable();
        if (ReturnDate <= EndDate) return 0f;
        int daysDelay = (ReturnDate.Value - EndDate).Days;
        return daysDelay * RENTAL_PENALTY_PER_DAY;
    }
}