// See https://aka.ms/new-console-template for more information


// Переменные
/*
 
const int MINUTES_IN_HOUR = 60;

    string name;
    name = "Bob";
    Console.WriteLine(name);
    name = "Bob1";
    Console.WriteLine(name);
    name = "Bob2";
    Console.WriteLine(name);

    Console.WriteLine(true);
    Console.WriteLine(false);

    Console.WriteLine(-10);
    Console.WriteLine(0);
    Console.WriteLine(0b10011);

    Console.WriteLine(1.24);
    Console.WriteLine(1.24F);

    Console.WriteLine('H');

    // Console.WriteLine(null);

    Console.WriteLine("It's a \t nice day!");
    Console.WriteLine("It's a \n nice day!");
    Console.WriteLine("It's a '\' nice day!"); // ????

    bool flag = true;
    flag = false;

    sbyte sb = 100;

    float a = 3.14F;
    float b = 3.14f;

    decimal c = 1005.5M;
    decimal c1 = 1005.5m;

    var d = 10;
    var d1 = 10.2F;
    var d2 = 'D';
        var d3 = "Thank's";

    int j;
    j = 20;
    var j1 = 20;

    Console.WriteLine("добро пожаловать в c#");
    Console.Write("надеюсь Вы ");
    Console.Write("вы постигнете ньюансы в c#! ");
    Console.WriteLine("и все будет гуд!");

    int j;
    j = 20;
    Console.WriteLine(j);
    Console.WriteLine("J=" + j);

    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.WriteLine("Имя:{0} Возраст:{2} Рост:{1}", name, height, age);
    Console.WriteLine($"Имя:{name} Возраст:{age} Рост:{height}");


    Console.WriteLine("введите свое имя:");
    string? name = Console.ReadLine();
    Console.WriteLine($"Ваше имя:{name}");

    Console.WriteLine("введите свой возраст:");
    string? age_str = Console.ReadLine();
    int age = Convert.ToInt32(age_str);
    Console.WriteLine($"Ваше возраст:{age}");
}
*/

// решение задачи
// подготовка данных
/*
  {
    bool isWhiteBreadFresh = true;
    ushort whiteBreadPrice = 150;
    ushort butterPrice = 230;
    ushort milkPrice = 170;
    float milkFatPercentage = 1.2F;
    ushort icecreaPrice = 350;

    Console.Write("Введите начальную сумму: ");
    string? sumString = Console.ReadLine();
    short sum = Convert.ToInt16(sumString);

    if (sum > 0)
    {
        if (isWhiteBreadFresh)
        {
            sum = Convert.ToInt16(sum - whiteBreadPrice);
        }
        sum = (short)(sum - butterPrice);
        if (milkFatPercentage == 1.2F)
        {
            sum = Convert.ToInt16(sum - milkPrice);
        }
        if (sum >= icecreaPrice)
        {
            sum = Convert.ToInt16(sum - icecreaPrice);

        }
        Console.WriteLine($"Остаток суммы: {sum}");
    }
    else 
    {
        Console.WriteLine("Сумма не может быть меньше нуля");
    }
}
*/
{
    ///////////////////////////////ДОМАШНЯЯ РАБОТА

    // Задание 1: консольный калькулятор

    /*    
           string operation;
           double result = 0;

           Console.WriteLine("Введите любое число1:");
           double a = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Введите операцию над числами: +,-,*,/");
           operation = Console.ReadLine();

           Console.WriteLine("Введите любое число2:");
           double b = Convert.ToDouble(Console.ReadLine());

           switch (operation)
           {
               case "+":
                   result = a + b;
                Console.WriteLine($"Результат операции:{result}");
                break;
               case "-":
                   result = a - b;
                Console.WriteLine($"Результат операции:{result}");
                break;
               case "/":
                {
                    if (b == 0)
                        Console.WriteLine("На ноль делить нельзя");
                    else
                        result = a / b;
                    Console.WriteLine($"Результат операции:{result}");
                    break;
                }
            case "*":
                   result = a * b;
                Console.WriteLine($"Результат операции:{result}");
                break;
           }
       */

    // Задание 2: проверка пападания числа в числовой промежуток

/*    
      Console.Write("Введите любое число от -50 до 50: ");
      string? sum = Console.ReadLine();
     int summ = Convert.ToInt16(sum);


    if (summ > 50)
    {
        Console.WriteLine($"Веденное число некорректно"); 
    }
    else if (summ  < -50)
    {
        Console.WriteLine($"Веденное число некорректно");
    }
    else if (summ > -40 && summ < -10)
    {
        Console.WriteLine($"Веденное число попадает в числовой промежуток [-40;-10]"); 
    }
    else if (summ > -9 && summ < 0)
    {
        Console.WriteLine($"Веденное число попадает в числовой промежуток [-9;0]");
    }
    else if (summ > 1 && summ < 10)
    {
        Console.WriteLine($"Веденное число попадает в числовой промежуток [1;10]");
    }
    else if (summ > 11 && summ < 40)
    {
        Console.WriteLine($"Веденное число попадает в числовой промежуток [11;40]");
    }
   */ 

    /*     // Задание 3: Английский словарь

        Console.Write("Введите любое слово о погоде:");
          string? word = Console.ReadLine();

          if (word == "солнечно")
          { 
                  Console.WriteLine("sunny");
          }
          else if (word == "ясно")
          {
              Console.WriteLine("clear");
          }
          else if (word == "пасмурно")
          {
              Console.WriteLine("Mainly cloudy");
          }
          else if (word == "туманно")
          {
              Console.WriteLine("foggy");
          }
          else if (word == "дождливо")
          {
              Console.WriteLine("it is rainy");
          }
          else if (word == "холодно")
          {
              Console.WriteLine("Cold");
          }
          else if (word == "облачно")
          {
              Console.WriteLine("cloudy");
          }
          else if (word == "слякоть")
          {
              Console.WriteLine("slush");
          }
          else if (word == "ветренно")
          {
              Console.WriteLine("windy");
          }
          else if (word == "жара")
          {
              Console.WriteLine("heat");
          }
          else
          {
              Console.WriteLine("Данного слова нет в словаре");
          }
    */

    // Задание 4: Проверка чисел на четность (второй вариант есть в теории: число в двоичной системе проверять таким образом - если последняя цифра 0 то число четное иначе - нечетное)
    /*
     Console.Write("Введите любое положительное целое число:");
     string? summString = Console.ReadLine();
     short chi = Convert.ToInt16(summString);
     short remainder = Convert.ToInt16(chi % 2);

     if (remainder != 0)
     {
         Console.WriteLine("Число не четное");
     }
     else
     {
         Console.WriteLine("Число четное");
     }
 */
}
