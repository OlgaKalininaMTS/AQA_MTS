namespace Generics;

public class Message  //
{
    public string Text { get; }

    public Message(string text)  // ����� 
    {
        Text = text;
    }

    public override string ToString()  //  ����� �������� ���������
    {
        return $"{nameof(Text)}: {Text}";
    }
}