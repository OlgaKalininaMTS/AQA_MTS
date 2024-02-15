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
                throw new Exception("��������� ������� ������: ����� �� ������, ����� ������ ������ 20 ��������, ����� �������� �������");
            }

            Console.WriteLine($"����� ����������: {login}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"������! {e.Message}");
        }
        try
        {
            if (password == null || password.Length > 20 || password.Contains(" "))
            {
                throw new Exception("��������� ������� ������: ������ �� ������, ����� ������ ������ 20 ��������, ������ �������� �������");
            }

            Console.WriteLine($"������ ����������: {password}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"������! {e.Message}");
        }

        try
        {
            if (confirmPassword != password)
            {
                throw new Exception("��������� ������� ������: �������� ������ �� ������, ������ �� ���������");
            }

            Console.WriteLine($"������ ������ ����������: {confirmPassword}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"������! {e.Message}");
        }

        return true;
    }
}