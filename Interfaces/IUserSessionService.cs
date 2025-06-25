public interface IUserSessionService
{
    bool IsLoggedIn { get; }
    string UserName { get; }

    void Login(string userName);
    void Logout();
}