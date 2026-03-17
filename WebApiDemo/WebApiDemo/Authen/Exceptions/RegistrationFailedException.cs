namespace WebApiDemo.Authen.Exceptions
{
    public class RegistrationFailedException(IEnumerable<string> errorDescription) 
        : Exception($"Registration failed with following error{string.Join(Environment.NewLine, errorDescription)}")
    { 
          
    }
}
