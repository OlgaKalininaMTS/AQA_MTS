namespace Delegate;

public class Example7
{
    delegate void Message();
    delegate int Operation(int x, int y);
    
    public void Run()
    {
        Message? msg = null;  // переменная м.б. null
        //msg(); выйдет ! Ошибка: делегат равен null
        msg?.Invoke();  // ? означает, что параметр м.б. null

        Operation op = Add;
        int result1 = op.Invoke(1, 2);

        op -= Add;
        //int result2 = op.Invoke(2, 3); // ! Ошибка: делегат равен null
        int? result3 = op?.Invoke(2, 3);
    }
    
    private void ShowMessage() => Console.WriteLine("Have fun!"); 
    
    private int Add(int x, int y) => x + y;
   /*  верхнюю строку можно прописать так
     private int Add(int x, int y)
    {
        return x + y;
    }
    */

}