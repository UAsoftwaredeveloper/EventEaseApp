using System;

public class UserSessionService
{
    public bool IsLoggedIn { get; private set; }
    public string UserName { get; private set; }

    public void Login(string userName)
    {
        UserName = userName;
        IsLoggedIn = true;
    }

    public void Logout()
    {
        UserName = null;
        IsLoggedIn = false;
    }
}