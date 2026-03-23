namespace APBD_Tutorial__2_CS_Object_Oriented_Project;

public class Student: User, IRentalHolder {
    public Student(string firstName, string lastName) : base(firstName, lastName) {
    }

    public int GetMaxActiveRentals() {
        return 2;
    }
}