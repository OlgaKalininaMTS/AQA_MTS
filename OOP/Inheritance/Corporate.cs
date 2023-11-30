namespace Abstraction;

public class Corporate : Client    // показывает наследование
{
    public string INN;
    public string UNP;

    public Corporate(int id) : base(id)   // показывает наследование
    {
        //Console.WriteLine("Corporate Base HashCode: " + base.GetHashCode());
    }
 
}