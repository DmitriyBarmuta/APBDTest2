namespace Test2.Exceptions;

public class NoSuchTrackException : Exception
{
    public NoSuchTrackException(string? message) : base(message)
    {
    }
}