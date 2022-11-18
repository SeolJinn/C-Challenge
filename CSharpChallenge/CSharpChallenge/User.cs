namespace CSharpChallenge;

public class User
{
    private string username, password, email;

    public User(string username, string password, string email)
    {
        this.username = username;
        this.password = password;
        this.email = email;
    }
    public string GetMail()
    {
        return email;
    }

    public void ChangePassword(string NewPassword)
    {
        password = NewPassword;
    }

    public override string ToString()
    {
        return username + " " + email;
    }
}