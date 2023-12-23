// See https://aka.ms/new-console-template for more information

namespace Delegate;

class Example2
{
    public delegate string WithParameters(string name1, string name2);
    
    public void Run()
    {
        WithParameters withParameters1 = new (ShowMessage);
        WithParameters withParameters2 = ShowMessage;
      //  WithParameters withParameters3 = null;  // в своем коде можно прописать так, а когда будет готов метод, то вписать его


        string result1 = withParameters1("Boris", "Ivan");
        string result2 = withParameters2("Olga", "Natasha");
     //   string result3 = withParameters3("Tany", "Ksenia");


        Console.WriteLine(result1);
        Console.WriteLine(result2);
     //   Console.WriteLine(result3);

    }

    private string ShowMessage(string value1, string value2)
    {
        Console.WriteLine($"{value1}, {value2} Have fun!!!");

        return "successful";  // результат выполнени метода
    }
}