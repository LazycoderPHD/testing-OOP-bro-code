public class User
{
    public string username;
    public string email;
    public int age;

    public User()
    {
        this.username = "Guest";
        this.email = "Not provided";
        this.age = 0;
    }
    public User(string username)
    {
        this.username = username;
        this.email = "Not provided";
        this.age = 0;
    }

     public User(string username, string email)
    {
        this.username = username;
        this.email = email;
        this.age = 0;
    }

    public User(string username, string email, int age)
    {
        this.username = username;
        this.email = email;
        this.age = age;
    }
}