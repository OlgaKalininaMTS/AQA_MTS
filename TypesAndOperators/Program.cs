// See https://aka.ms/new-console-template for more information

{
    ///////////////////////////////ДОМАШНЯЯ РАБОТА

    // Задание 1: консольный калькулятор

        
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
