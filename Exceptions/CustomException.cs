namespace Exceptions;

public class CustomException : System.Exception
{
    // Конструктор с возможностью передачи сообщения об ошибке
    public CustomException(string message) : base(message)
    {
    }
}