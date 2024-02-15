// See https://aka.ms/new-console-template for more information

using Exceptions;  // исключения

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Проверка корректного ввода логина и пароля");
        LoginPasswordRule.CheckLoginPassword(login: "olga", password: "fhgf5", confirmPassword: "fhgf5");
        
        Console.WriteLine("Повторная проверка с новыми данными");
        LoginPasswordRule.CheckLoginPassword(login: "ol ga", password: "fhgf5", confirmPassword: "fhgf5");

        Console.WriteLine("Повторная проверка с новыми данными");
        LoginPasswordRule.CheckLoginPassword(login: "olga", password: "qwertyuioplkjhgfdsazx", confirmPassword: "op5gh_m");

        Console.WriteLine("Повторная проверка с новыми данными");
        LoginPasswordRule.CheckLoginPassword(login: "olga", password: "fhgf5", confirmPassword: "fhgf56");
    }
}
