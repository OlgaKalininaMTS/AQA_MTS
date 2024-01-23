namespace NUnitProject
{   
    public class SimpleTest : PrePostConditionExample  // если делаем этот класс наследуемым от PrePostConditionExample
    {                                                  //, то автоматом появятся [OneTimeSetUp],  [SetUp] и т.д.
        /*[Test]  // аннотация
        public void Test1()
        {
            Assert.Fail();
        }*/

        [SetUp]  // метод выполняется перед каждым тестовым методом, данный метод наследуется
        public void Setup1()
        {
            Console.WriteLine($"{this}: SetUp1...");
        }
        [Test]  // аннотация
        public void Test3()
        {
            Console.WriteLine($"{this}: Test3...");   // this - в каком классе я сейчас нахожусь
            Assert.Pass();
        }
    }
 
}


// stack trace - где и что упало в тесте
// при нажатии ПКМ - Run ,то выполнятся все тесты, содержащие аннотацию [Test]
// только с аннотацией [Test] можно запустить тест на выполнение

/*   public class SimpleTest  // если прописывать без наследования
    {
       //[Test]  // аннотация
     //   public void Test1()
      //  {
      //      Assert.Fail();
     //   }

        [Test]  // аннотация
        public void Test2()
        {
            Console.WriteLine($"{this}: Test...");   // this - в каком классе я сейчас нахожусь
            Assert.Pass();
        }
    }
  */