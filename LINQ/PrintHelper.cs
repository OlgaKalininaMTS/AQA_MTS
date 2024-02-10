using System.Collections;

namespace LINQ;

    internal class PrintHelper
{
    public static void Print(IEnumerable array)
    {
        foreach (var item in array)
        {
            Console.Write($"{item}");
        }
        Console.WriteLine();
    }
}
