using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace CSharpChallenge;

public abstract class Application
{
    private string name;
    private int MaxUsers = 0;
    private List<User> UserList = new List<User>();

    public Application(string name, int mu, List<User> a)
    {
        this.name = name;
        this.MaxUsers = mu;
        List<User> UserList = a;
    }
    
    public string GetName()
    {
        return name;
    }

    public int GetNumberOfUsers()
    {
        return MaxUsers;
    }
    public override string ToString()
    {
        return name + " " + MaxUsers;
    }

    public void AddUser(string name, string pass, string mail)
    {
        MaxUsers++;
        User a = new User(username: name, password: pass, email: mail);
        UserList.Add(a);
    }

    public void RemoveUser(string name)
    {
        User a = new User(username: name, password: "1", email: "1");
        UserList.Remove(a);
    }
}