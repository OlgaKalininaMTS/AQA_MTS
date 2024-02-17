using Collections;
using System.Collections;
using System.Text;

namespace Collections;

public class DictionaryProducts    // структура дерева
{
    ArrayList stringList = new ArrayList();
    public void Run()
    {
        ArrayList stringList1 =
       [
           new Random().Next(1,100),
           "Яблоко",
           10,
           50
       ];
        ArrayList stringList2 =
      [
          new Random().Next(101,200),
          "Апельсин",
          15,
          24
      ];
        ArrayList stringList3 =
      [
          new Random().Next(201,300),
          "Слива",
          13,
          48
      ];

        Console.WriteLine("Элементы в ArrayList:");
        foreach (var item in stringList) // Рекомендуемый вариант
        {
            Console.WriteLine(item);
        }
    }
}