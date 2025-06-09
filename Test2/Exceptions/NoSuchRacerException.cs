namespace Test2.Exceptions;

public class NoSuchRacerException : Exception
{
    public NoSuchRacerException(string? message) : base(message)
    {
    }
}