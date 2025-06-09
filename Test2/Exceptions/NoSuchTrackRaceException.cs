namespace Test2.Exceptions;

public class NoSuchTrackRaceException : Exception
{
    public NoSuchTrackRaceException(string? message) : base(message)
    {
    }
}