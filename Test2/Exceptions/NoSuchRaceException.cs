namespace Test2.Exceptions;

public class NoSuchRaceException : Exception
{
    public NoSuchRaceException(string? message) : base(message)
    {
    }
}