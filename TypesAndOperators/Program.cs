// See https://aka.ms/new-console-template for more information


// комментарий

/* Это сообщение будет выведено на экран

Console.WriteLine("Hello, World!");
{
    Console.WriteLine("It's a nice day!");
}
*/


// Переменные
/*
{ 
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

