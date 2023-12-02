namespace Encapsulation;

public class State
{
    // все равно, что private string defaultVar (частная строка по умолчанию Var);
    string defaultVar = "default";

    // поле доступно только из текущего класса (аналогична предыдущей)
    private string privateVar = "private";

    // доступно в любом месте программы, а также для других программ и сборок
    public string publicVar = "public";

    // доступно из текущего класса и производных классов
    protected string protectedVar = "protected";

    // доступно в любом месте текущего проекта
    internal string internalVar = "internal";

    // доступен в любом месте программы, а также для других программ и сборок
    public void PrintPublic() => Console.WriteLine(publicVar);

    // доступно из текущего класса и производных классов, которые определены в этом же проекте
    protected private string protectedPrivateVar = "protected private";

    void Test()
    {
        PrintPrivate();
        PrintPublic();
    }
   /* private class StateInside
    {
        void Test()
        {
            PrintPrivate();
        }
    }*/

    // метод доступен только из текущего класса
    private void PrintPrivate() => Console.WriteLine(privateVar);


    // доступно в любом месте текущего проекта и из классов-наследников в других проектах
    protected internal string protectedInternalVar = "protected internal";
   
    
    // доступен в любом месте текущего проекта и из классов-наследников в других проектах  метод
    protected internal void PrintProtectedInternal() => Console.WriteLine(protectedInternalVar);

    // доступен из текущего класса и производных классов, которые определены в этом же проекте
    protected private void PrintProtectedPrivate() => Console.WriteLine(protectedPrivateVar);

    /*   
     
       // по умолчанию имеет модификатор private
       void Print() => Console.WriteLine(defaultVar);


       

       // доступен из текущего класса и производных классов
       protected void PrintProtected() => Console.WriteLine(protectedVar);

       // доступен в любом месте текущего проекта
       internal void PrintInternal() => Console.WriteLine(internalVar);

       

      
    */
}