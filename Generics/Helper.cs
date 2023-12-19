namespace Generics;

public static class Helper
{
    public static void Swap<T>(ref T x, ref T y)  // метод - меняет местами 2 значения; ref  - ссылка на переменную
    {
        T tmp = x;
        x = y;
        y = tmp;
        // (x, y) = (y, x); либо можно написать так
    }
    
    public static void SendMessage(Message message)  //
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }
    
    /*
    public static void SendMessage<T>(T message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");   // ! Ошибка - свойство Text
    }
    */
    
    public static void SendMessage<T>(T message) where T: Message     // метод Т может быть только Message, т.е. string
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }
}