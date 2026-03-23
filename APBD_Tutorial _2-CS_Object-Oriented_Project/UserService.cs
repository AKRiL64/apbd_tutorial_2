namespace APBD_Tutorial__2_CS_Object_Oriented_Project;

public class UserService {
    private readonly List<User> users = [];

    public void Add(User user) {
        users.Add(user);
    }

    public User GetById(int id) {
        return users.Single(u => u.Id == id);
    }

    public IEnumerable<User> GetAll() {
        return users;
    }
}