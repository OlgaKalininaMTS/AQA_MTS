using Polymorphism;

public class Individual : Client
{
    public string Firstname;
    public string Lastname;
    
    public Individual(int id) : base(id)
    {
        Console.WriteLine("Individual Base HashCode: " + base.GetHashCode());
    }

    public override void SendNotification()  // перегружаем виртуальный метод
    {
        base.SendNotification();  // сначала вызываем метод из базового класса
        Console.WriteLine("Уважаемый клиент...");   // потом делаем свое
    }
}