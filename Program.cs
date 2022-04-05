using cSharpLoginTool.Model;

User haven = new User("haven", "123");
User mark = new User("mark", "321");

Dictionary<string, User> users = new Dictionary<string, User>(){
{haven.Name, haven},
{mark.Name, mark}
};

Console.Clear();
Console.WriteLine("Welcome, please login: ");
Console.Write("Login: ");
string? username = Console.ReadLine()?.ToLower();
Console.Write("Password: ");
string? password = Console.ReadLine();


if (users.ContainsKey(username) && users[username].ValidatePassword(password))
{
  Console.WriteLine("System Activated");
}
else
{
  Console.WriteLine("System Self-Destructing");
}



