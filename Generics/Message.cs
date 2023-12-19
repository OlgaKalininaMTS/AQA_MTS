namespace Generics;

public class Message  //
{
    public string Text { get; }

    public Message(string text)  // метод 
    {
        Text = text;
    }

    public override string ToString()  //  метод отправки сообщений
    {
        return $"{nameof(Text)}: {Text}";
    }
}