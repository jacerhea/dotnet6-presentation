public record User(int Id, string Name, int Age);

public class MyService
{
    private List<User> users = new()
    {
        new User(1, "John", 30),
        new User(2, "Jane", 25),
        new User(3, "Joe", 20)
    };

    public User GetUser(int id) =>
        users.Single(user => user.Id == id);
};
