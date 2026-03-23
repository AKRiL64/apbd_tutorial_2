namespace APBD_Tutorial__2_CS_Object_Oriented_Project;

public class Employee: User{
    public Employee(string firstName, string lastName) : base(firstName, lastName) {
    }

    public override int GetMaxActiveRentals() {
        return 5;
    }
}