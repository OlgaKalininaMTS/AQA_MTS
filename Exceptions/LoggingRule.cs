namespace Exceptions;

public class LoggingRule
{
   public string login;
    public string password;
    public string confirmPassword;
    
   
    public static bool Rules (string login, string password, string confirmPassword)
    {

         /*   if (login.Length <= 20)
            {
                throw new WrongPasswordException("Пароль не должен превышать 20 символов");
             }

           */
       
        return true;
    }

}