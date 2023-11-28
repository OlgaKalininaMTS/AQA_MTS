namespace Classes;

public class ConstructorCustom     // можем создать несколько конструкторов с разными параметрами
{
    public int sizeMain;
    public string textMain;
    
    public ConstructorCustom(int size)
    {
        sizeMain = size;
    }

    public ConstructorCustom(string text)
    {
        textMain = text;
    }
}