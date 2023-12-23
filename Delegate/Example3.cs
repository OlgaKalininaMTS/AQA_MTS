namespace Delegate;

public class Example3
{
    // Тип делегата
    public delegate void Notification();

    public void Run()
    {
        Notification noPrm = ShowMessage1;
      //  Notification noPrm2 = ShowMessage2;  // можно прописать и так


          noPrm += ShowMessage1; 
          noPrm += ShowMessage1;  // вызов второго метода, можно прописать так:  noPrm = noPrm + ShowMessage2;
         noPrm += ShowMessage2;  // вызов второго метода, можно прописать так:  noPrm = noPrm + ShowMessage2;
        // вызов второго метода, можно прописать так:  noPrm = noPrm + ShowMessage2;
  
        noPrm -= ShowMessage2;  // метод можно удалить


        noPrm.Invoke(); // Более унифицированный вызов методов делегата; 
     // noPrm2.Invoke(); // можно прописать и так 

    }

    private void ShowMessage1() => Console.WriteLine("Have fun!");  // метод 1

    private void ShowMessage2() => Console.WriteLine("See you!");  // метод 2 
}