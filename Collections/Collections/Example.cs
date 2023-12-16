using Collections.Helper;

namespace Collections;

public class Example
{
    public void Run()
    {
        Dictionary<string, List<int>> studentsGrades = new Dictionary<string, List<int>>();

        studentsGrades.Add("Sasha", new List<int> { 7, 9, 10});
        studentsGrades.Add("Masha", new List<int> { 10, 9, 10});
        studentsGrades.Add("Stas", new List<int> { 5, 6, 7});

        foreach (var item in studentsGrades)
        {
          var verageMark =  item.Value.Average();
            Console.WriteLine($"Средняя оценка : {verageMark}");
        }


    }
}