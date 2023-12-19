namespace Generics;

public struct MessageStruct  // структура
{
    public string Text { get; }   

    public MessageStruct(string text)  // конструктор
    {
        Text = text;
    }

    public override string ToString()
    {
        return $"{nameof(Text)}: {Text}";
    }
}