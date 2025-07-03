public class UserSessionService
{
    public UserRegistration? CurrentUser { get; private set; }

    public void SetUser(UserRegistration user)
    {
        CurrentUser = user;
    }

    public UserRegistration? GetUser() => CurrentUser;
}
