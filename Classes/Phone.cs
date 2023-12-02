using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classes;
using Classes;

public class Phone
{
    public string number;   // номер
    public string model;      // модель
    public int weight;    // вес
    public string name;

  
    public void receiveCall(string name)
    {
        Console.WriteLine($"Звонит: {name}");
    }

    public void getNumber(string number)
    {
        Console.WriteLine($"Номер телефона: {number}");
    }
    
     public string sendMessage (params string[] numbers)
    {
        string num = " ";
        Console.WriteLine($"Номера телефонов, на которые будет отправлено сообщение: ");
        foreach (string numb in numbers)
        {
            Console.WriteLine(numb);
        }
        return num;
       
    }
    

}


