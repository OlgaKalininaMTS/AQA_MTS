namespace Generics;

public class EmailMessage : Message  // �������� ����� �� Message
{
    public EmailMessage(string text) : base(text)
    {
    }

    public EmailMessage() : base("Email Message by default.")
    {
    }
}