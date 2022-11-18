using CSharpChallenge;

User u = new User(username:"SeolJinn",password:"1234",email:"jwoo2376@gmail.com");

Console.WriteLine(u.GetMail());
u.ChangePassword("4321");
Console.WriteLine(u.ToString());

