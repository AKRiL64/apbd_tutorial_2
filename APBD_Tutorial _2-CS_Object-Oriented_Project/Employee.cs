namespace APBD_Tutorial__2_CS_Object_Oriented_Project;

public class Employee: User, IRentalHolder {
    public Employee(string firstName, string lastName) : base(firstName, lastName) {
    }

    public int GetMaxActiveRentals() {
        return 5;
    }
}