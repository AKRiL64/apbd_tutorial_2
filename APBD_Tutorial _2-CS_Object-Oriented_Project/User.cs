namespace APBD_Tutorial__2_CS_Object_Oriented_Project;

public abstract class User: IRentalHolder {
    private static int _id = 1;

    public int Id { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    protected User(string firstName, string lastName)
    {
        Id = _id++;
        FirstName = firstName;
        LastName = lastName;
    }

    public abstract int GetMaxActiveRentals();
}