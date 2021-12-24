namespace EZ.Retrier;

public class RetryException : Exception
{
    public RetryException(string message) : base(message)
    {
    }
}