namespace LINQ;

public class Program
{
    static void Main()
    {
        // Testing Task
        //   TestTask testTask = new TestTask();
        //   testTask.Solve();

        // Base Sytanx
        //  new BaseSyntax().RunQuerySyntax();
        //   new BaseSyntax().RunMethodSyntax();
        //   new BaseSyntax().RunStringExtension();


        // Where
        //   new Where().RunQuerySyntax();
        //  new Where().RunMethodSyntax();

        // Select
        //      new Select().RunQuerySyntax();
        //       new Select().RunMethodSyntax();

        // Два в одном
        //       new TwoInOne().run();

        // Переменные
        //   new Variables().RunQuerySyntax();
        //    new Variables().RunMethodSyntax();

        // Агрегация данных
        //             new DataAggregation().RunQuerySyntax(); 
        //           new DataAggregation().RunMethodSyntax();

        // Сортировка
        //           new OrderBy().RunQuerySyntax();
        //            new OrderBy().RunMethodSyntax();

        // Группировка
        //        new GroupBy().RunQuerySyntax();


        //Объединение, пересечение и разность коллекций:
        // разность
        //     new Except().RunQuerySyntax();
        //    new Except().RunMethodSyntax();

        // Пересечение
        //       new Intersect().RunQuerySyntax();
        //           new Intersect().RunMethodSyntax();

        // Объединение
        //      new Union().RunQuerySyntax();
        //      new Union().RunMethodSyntax();

        // Удаление дубликатов
        //    new Distinct().RunQuerySyntax();
        //     new Distinct().RunMethodSyntax();

        // Сложный объект (Union)
        //      new ComplexObject().RunQuerySyntax();
        //      new ComplexObject().RunMethodSyntax();

        // Aggregation
        //     new Aggregation().RunQuerySyntax();
        //       new Aggregation().RunMethodSyntax();

        // Single Item
        // new SingleItem().RunQuerySyntax();
        //  new SingleItem().RunMethodSyntax();

        // Методы Skip и Take
        // new SkipTake().RunQuerySyntax();
        // new SkipTake().RunMethodSyntax();

        // Методы All и Any        
        // new Condition().RunMethodSyntax();

        // Методы Join        
        new Join().RunQuerySyntax();
        new Join().RunMethodSyntax();
    }
}