internal class User
{
    private string _UserName;
    private string _Password;
    public string UserName
    {
        get { return _UserName; }
        set { _UserName = value; }
    }
    public string Password
    {
        get { return _Password; }
        set
        {
            if (CheckPassword(value) == true)
            {
                _Password = value;
            }
        }

    }

    public User(string userName, string password)
    {
        this.UserName = userName;
        this.Password = password;
    }


    public bool CheckPassword(string password)
    {
        bool status = false;
        if (password.Length > 7 && password.Any(char.IsUpper))
        {
            status = true;
        }
        else
        {
            Console.WriteLine("Zehmet olmasa 1 herfi boyuk olan minimum 8 simvollu password daxil edin");
        }
        return status;
    }

}