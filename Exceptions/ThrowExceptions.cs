namespace Exceptions;

public class ThrowExceptions
{
    public void CheckUsername()
    {
        try
        {
            Console.Write("Введите имя: ");
            string? name = Console.ReadLine();
            if (name == null || name.Length < 2)
            {
                throw new System.Exception("Длина имени меньше 2 символов");
            }

            Console.WriteLine($"Ваше имя: {name}");
        }
        catch (System.Exception e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
    
    public void CheckUsername1()
    {
        try
        {
            try
            {
                Console.Write("Введите имя: ");
                string? name = Console.ReadLine();
                if (name == null || name.Length < 2)
                {
                    throw new System.Exception("Длина имени меньше 2 символов");
                }

                Console.WriteLine($"Ваше имя: {name}");
            }
            catch (System.Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
                throw;   // вызов Exception еще раз
            }
        }
        catch (System.Exception ex)  // снова срабатывает блок catch, но более высокоуровневый
        {
            Console.WriteLine(ex.Message);
        }
    }
    
}