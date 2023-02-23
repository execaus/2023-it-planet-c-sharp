namespace it_planet.repository.postgres;

public class InvalidRequestFieldException : Exception
{
    public InvalidRequestFieldException(string message) : base(message) {}
}