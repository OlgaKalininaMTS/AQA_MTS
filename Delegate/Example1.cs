
namespace Delegate;

public class Example1
{
    // Тип делегата
    private delegate void NoParameters();
    
    public void Run()
    {
        // Экземпляр делегата   NoParameters  - это тип, а noParameters1 - это параметр
        NoParameters noParameters1 = new NoParameters(ShowMessage);  // ShowMessage имя параметра это имя метода
        NoParameters noParameters2 = new (ShowMessage);  // более укороченный вариант написания
        NoParameters noParameters3 = ShowMessage;   // более укороченный вариант написания
       

        noParameters1();  // запускаем мотод через делегат
        noParameters2();
        noParameters3();
    


    }

    private void ShowMessage()
    {
        Console.WriteLine("Have fun!!!");
    }
   
    
}

