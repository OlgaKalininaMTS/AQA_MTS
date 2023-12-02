using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classes;
using Classes;

public class CreditCard
{
    public int AccountNumber;   
    public int Accountsumma;    
   

    void SimpleAdd ( int y)
    {
        Accountsumma = Accountsumma + y;

        Console.WriteLine($"Сумма на счету после зачисления: {Accountsumma}");
    }

    void SimpleSub(int b)
    {
        Accountsumma = Accountsumma - b;

        Console.WriteLine($"Сумма на счету после снятия: {Accountsumma}");
    }




}


