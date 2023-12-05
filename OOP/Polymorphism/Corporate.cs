using Polymorphism;
public class Corporate : Client
{
    public string INN;
    public string UNP;

    public Corporate(int id) : base(id)
    {
        Console.WriteLine("Corporate Base HashCode: " + base.GetHashCode());
    }

    public override void SendNotification()    // перегружаем виртуальный метод - полностью заменяем внутри
    {
        Console.WriteLine("Дорогие сотрудники компании....");
    }

   /* public override seald void SendNotification()    // перегружаем виртуальный метод - полностью заменяем внутри
    {
        Console.WriteLine("Дорогие сотрудники компании....");
    }
   */


    public override sealed string Address
    {
        get
        {
            return base.Address + " " + INN;
        }
        set
        {
            base.Address = "Corpotare Address: " + value;
        }
    }
}