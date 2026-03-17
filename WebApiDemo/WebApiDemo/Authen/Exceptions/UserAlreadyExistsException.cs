namespace WebApiDemo.Authen.Exceptions
{
    public class UserAlreadyExistsException(string email) 
        : Exception($"User with email: {email} alredy exist")
    {
    }
}
