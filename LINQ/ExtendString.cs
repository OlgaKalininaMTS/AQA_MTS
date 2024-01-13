namespace LINQ;

public static class ExtendString
{
    public static char GetChar(this string value, int index)  // статический метод: на вход получ 
    {
        return value[index];
    }
}