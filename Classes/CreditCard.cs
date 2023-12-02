using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classes;
using Classes;

public class CreditCard
{
    public int AccountNumber;   
    public int Accountsumma ;

       public void SimpleAdd (int y)
    {
        Accountsumma = Accountsumma + y;

        Console.WriteLine($"Сумма на счету после зачисления: {Accountsumma}");
    }

    public void SimpleSub(int b)
    {
        Accountsumma = Accountsumma - b;

        Console.WriteLine($"Сумма на счету после снятия: {Accountsumma}");
    }
  

    public void SimpleInfo()
    {
        Console.WriteLine($"Номер карты: {AccountNumber} \t Текущая сумма на счету: {Accountsumma}");
    }
    
    
    
    



}


