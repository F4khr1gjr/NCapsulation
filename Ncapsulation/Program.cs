
Console.WriteLine("User Name daxil edin");
string UserName = Console.ReadLine();
Console.WriteLine("Password daxil edin");
string Password = Console.ReadLine();


User user = new User(UserName, Password);



if (user.Password != null && user.UserName != null)
{
    Console.WriteLine("Dogrudur");
}
else
{
    Console.WriteLine("Yanlisdir");
}
