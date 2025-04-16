namespace BookEFApp.Dal;

public class HorsSujetException: Exception
{
    private DateOnly _inputDate;

    public HorsSujetException(string message, DateOnly inputDate): base(message)
    {
        _inputDate = inputDate;
    }
}