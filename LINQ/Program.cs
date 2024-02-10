namespace LINQ;

public class Program
{
    /////////////////////////////////////////// Домашняя работа. Задание 1
    /* 
     static void Main()
     {
         List<int> intsequens = new List<int> { 5, 1, 2, 3, 3, 4, 5, 6, 7, 5, 8, 9, 10, 11, 12, 13, 3, 14, 15, 16, 17, 18, 9, 19, 19, 20 };

         Console.WriteLine("Исходная целочисленная последовательность:");
         PrintHelper.Print(intsequens);


         var sequens = intsequens.Where(number => (number % 2 != 0)).Distinct();

         Console.WriteLine("Последовательность нечетных числел: ");
         PrintHelper.Print(sequens);

     }
    */


    /*///////////////////////////////////////////////////// Задание 2
    public static void Main()
    {
        List<Person> personList =                 // последовательность сведений о клиентах фитнес-центра
            [
                new Person(1, 2021, 4, 3),
                new Person(2, 2021, 5, 1),
                new Person(3, 2021, 8, 2),
                new Person(4, 2021, 2, 24),
                new Person(5, 2021, 3, 32),
                new Person(6, 2021, 7, 48),
                new Person(7, 2021, 1, 13),
                new Person(8, 2021, 6, 11),
                new Person(9, 2021, 9, 19),
            ];

      
              var MinTrainingTime =
                  (from person in personList
                   orderby person.TrainingTime descending
                   select person).Last();
        
       Console.Write($"Минимальная продолжительность занятия: {MinTrainingTime.TrainingTime} ч., год: {MinTrainingTime.Year}, номер месяца: {MinTrainingTime.NumMonth}");
    }
    */

    ////////////////////////////////////// Задание 3
    ///
    static void Main()
    {
        var lines = new[] { "GIRAFFE", "KOALA", "PIG", "PORCUPINE", "CAPYBARA", "AARDVARK", "BINTURONG", "MUSANG" }; // строковая последовательность
        var sortLines = lines.OrderBy(s => s.Length).ThenByDescending(s => s);

        Console.WriteLine("Отсортированная последовательность по возрастанию длин строк, а строки одинаковой длины – по убыванию алфавита: ");
        foreach (var lin in sortLines)
        {
            Console.WriteLine(lin);
        }

    }
}
