namespace Interfaces.FinalExample;

public class ApplicationTester : ITestable  // 
{
    private Test[] _tests = new Test[100];   // группа тестов (через массив) присутствует только в этом классе (private)
    private int _index = 0;                     // параметр - с каким тестом сейчас работаю

    public void AddTest(Test test)   // метод - добавление тестов
    {
        _tests[_index++] = test;
    }

    public void RunTests()   // метод запуска тестов
    {
        for (int i = 0; i < _index; i++)
        {
            _tests[i].Run();            
        }
    }
}
