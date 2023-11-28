using System.Security.Cryptography.X509Certificates;
using Classes.Models;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int[] array = { 1, 8, 14, -4, 0, 7 };
              foreach (var item in array)
              {
                  Console.Write($"{item}\t");
              }
              Console.WriteLine();

              Array.Reverse(array);
              {
                  foreach (var item in array)
                  {
                      Console.Write($"{item}\t");
                  }

                  Console.WriteLine();
              }
              ////////////////////////////////////////////////////////////////////////////////////////
              PrintArray(array);  // обозначаем что создаем метод

              void PrintArray(int[] arr)
              {                          // void - ничего не возвращается, поэтому не используется return
                  foreach (var item in arr)
                  {
                      Console.Write($"{item}\t");
                  }

                  Console.WriteLine();
              }


              // -=================== Метод без параметров ===================-
              void MethodWithoutParameters()
              {
                  // Тело метода
              }
             

            // -=================== Метод без возвращаемого значения ===================-
            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }

            PrintMessage("Text");

            string tmp = "lalala";
            PrintMessage(tmp);
            

            // -=================== Метод с параметрами по умолчанию ===================-
               void DisplayGreeting(string greetingMessage, string name = "Гость")
                {
                   Console.WriteLine($"{greetingMessage}, {name}!");
                }

            DisplayGreeting("Hello");             // Hello, Гость!
            DisplayGreeting("Hello", "Alex");     // Hello, Alex!
            DisplayGreeting("Alex", "Hello");     // Alex, Hello!
*/

            // -=================== Метод с переменным числом аргументов ===================-
            /*    int CalculateSum(params int[] numbers)
                      {
                          int sum = 0;

                          foreach (int num in numbers)
                          {
                              sum += num;
                          }
                          return sum;
                      }

                      int sum1 = CalculateSum(1, 2, 3, 4, 5);
                      int sum2 = CalculateSum(); // Пустой вызов

                      Console.WriteLine("Sum 1: " + sum1);  // Sum 1: 15
                      Console.WriteLine("Sum 2: " + sum2);     // Sum 2: 0
            */

            // -=================== Передача параметров ===================-   28.11.2023
            // -=================== По значению

            /*     void SimpleAdd(int x, int y)                //По умолчанию аргументы передаются по значению,
                 {
                     int ans = x + y;                        // Вызывающий код не увидит эти изменения, т.к. модифицируется копия исходных данных,

                     // Разкомментировать  нельзя присвоить значения параметров из метода
                    // х = 10000;       нельзя
                    // у = 88888;       нельзя
                 }
      */
            // -=================== По ссылке
            // -=================== Out  необязательно инициализировать, но обязательно менять
            // Значения выходных параметров должны быть установлены внутри вызываемого метода.
            /* void OutAdd(int x, int y, out int ans)    // с использованием ключевого слова out
             {                                          // ans позволяет присвоить значения параметрам
                 ans = x + y;
             }

             OutAdd(90, 90, out int ans1);
             Console.WriteLine("OutAdd: 90 + 90 = {0}", ans1);

             //   int ans;
             //   OutAdd(90, 90, out ans);
             //   Console.WriteLine("OutAdd: 90 + 90 = {0}", ans);
            */
            /* static void OutAdd (int x, int y, out int ans)    // с использованием ключевого слова out
                       {
                           ans = x + y;
                       }
             */
            // Присваивать начальные значения локальным переменным, используемым как выходные параметры, не обязательно
            // при условии, что они впервые используются
            /*  OutAdd(90, 90, out int ans); // - Первый вариант

                        //int ans;
                        //Add(90, 90, out ans); // - Второй вариант

                        Console.WriteLine("OutAdd: 90 + 90 = {0}", ans);

                        // Практическое применение в тестировании - возврат данных
                        void FillTheseValues(out int a, out string b, out bool c)
                        {
                            a = 9;
                            b = "Enjoy your string.";
                            c = true;
                        }
            */

            // -=================== Ref  обязательно инициализировать, но необязательно менять
            /*            void ModifyValue(ref int value)
                        {
                            value = value * 2;    //можно написать так value *=2;
                        }

                        int mainValue = 5;      // Если закоментировать - будет ошибка, обязательно необходимо присваивать значение
                        Console.WriteLine($"mainValue is {mainValue}");
                     
                        ModifyValue(ref mainValue);
                        Console.WriteLine($"mainValue now is {mainValue}");

                        // -=================== Возврат значений ===================-
                        // -=================== Возврат значения
                        int GetPersonAge()      // если проставляем методу тип, то обязательно использовать return
                        {                                               //
                          return 25;

                        }

                        Console.WriteLine($"Age: {GetPersonAge()}");

                        // -=================== Возврат нескольких значений
                        (string, int) GetPersonInfo()       //  (string, int) это сигнатура
            {
                            return ("John", 25);           // последовательность должна соответствовать сигнатуре
                        }

                        var person = GetPersonInfo();
                        Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}");
           */
            // -=================== Сжатый метод
            /*        int ShortAdd(int х, int у) => х + у;

                     // -=================== Рекурсивная функция   главное правильно установить точку остановки
                     int Factorial(int n)
                     {
                         if (n == 1) return 1;    // точка остановки

                         return n * Factorial(n - 1);
                     }

                     int factorial4 = Factorial(4);  // 24=4*3*2
                     int factorial5 = Factorial(5);  // 120=5*4*3*2
                     int factorial6 = Factorial(6);  // 720=6*5*4*3*2

                     Console.WriteLine($"Факториал числа 4 = {factorial4}");
                     Console.WriteLine($"Факториал числа 5 = {factorial5}");
                     Console.WriteLine($"Факториал числа 6 = {factorial6}");
            */

            // -=================== КЛАССЫ ========================================================================================================-
            // -=================== Структура класса
            /*         EmptyClass emptyClassObject = new EmptyClass();   // тип классов содержит название класса, обект класса содержит название класса

                     Person personObj = new Person();         // создали объект класс Person
                     Person personObj2 = new Person();         // создали объект класс Person

                    personObj.Print();        // метод вернет начальные значения класса

                     personObj.name = "Alex";     // меняем значения класса и выводим это на экран
                     personObj.age = 45;
                     personObj.Print();
                     personObj2.Print();
            */
            // -=================== Создание конструкторов

            /*  PersonWithConstructor personWithConstructor = new PersonWithConstructor();
              personWithConstructor.Print();

                     ConstructorByDefault constructorByDefault = new ConstructorByDefault();

                     ConstructorCustom constructorCustom1 = new ConstructorCustom(10);
                     constructorCustom1 = new ConstructorCustom("text");   // пересоздаем коструктор

                    ConstructorCustom constructorCustom2 = new ConstructorCustom("text");

                     ConstructorFull constructorFull1 = new ConstructorFull();
                     ConstructorFull constructorFull2 = new ConstructorFull(1);
                     ConstructorFull constructorFull3 = new ConstructorFull("test");
            */
            // -=================== Цепочка вызова конструкторов
                   PersonChain personChain1 = new PersonChain();
                   PersonChain personChain2 = new PersonChain("Alex");
                   PersonChain personChain3 = new PersonChain("Alex", 45);

                   personChain1.Print();
                   personChain2.Print();
                   personChain3.Print();

                   // -=================== Первичные конструкторы
                   // PersonPrimaryConstructors personPrimaryConstructors1 = new PersonPrimaryConstructors();          - Ошибка
                   PersonPrimaryConstructors personPrimaryConstructors2 = new PersonPrimaryConstructors(name: "Alex");
                   // PersonPrimaryConstructors personPrimaryConstructors3 = new PersonPrimaryConstructors(age: 45);   - Ошибка соответствия сигнатуре (порядку параметров)
                   PersonPrimaryConstructors personPrimaryConstructors4 = new PersonPrimaryConstructors(name: "Alex", age: 45);

                   personPrimaryConstructors2.Print();
                   personPrimaryConstructors4.Print();
            
            // -=================== This

         //   PersonThis personThis = new PersonThis("Alex", 45);
            
                   
        }
    }
}