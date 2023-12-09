namespace Exceptions;

public class InvalidInputException : Exception
{
    public InvalidInputException(string fieldName, string message)    // fieldName - именно в этом поле произошла ошибка
        : base($"Неверный ввод в поле '{fieldName}': {message}")
    {
    }
}