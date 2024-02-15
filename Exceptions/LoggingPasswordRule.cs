namespace Exceptions;

internal class LoginPasswordRule
{
    public LoginPasswordRule(string login, string password, string confirmPassword)
    {
        Login = login;
        Password = password;
        ConfirmPassword = confirmPassword;
    }
    private static string Login { get; set; }
    private static string Password { get; set; }
    private static string ConfirmPassword { get; set; }

    public static bool CheckLoginPassword(string? login, string? password, string? confirmPassword)
    {
        try
        {
            if (login == null || login.Length > 20 || login.Contains(" "))
            {
                throw new Exception("Возможная причина ошибки: логин не введен, длина логина больше 20 символов, логин содержит пробелы");
            }

            Console.WriteLine($"Логин корректный: {login}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка! {e.Message}");
        }
        try
        {
            if (password == null || password.Length > 20 || password.Contains(" "))
            {
                throw new Exception("Возможная причина ошибки: пароль не введен, длина пароля больше 20 символов, пароль содержит пробелы");
            }

            Console.WriteLine($"Пароль корректный: {password}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка! {e.Message}");
        }

        try
        {
            if (confirmPassword != password)
            {
                throw new Exception("Возможная причина ошибки: повторно пароль не введен, пароли не совпадают");
            }

            Console.WriteLine($"Повтор пароля корректный: {confirmPassword}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка! {e.Message}");
        }

        return true;
    }
}