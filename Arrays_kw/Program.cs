// Массивы

//   int[] array;
//   array = new int[4];

//   int[] array = { 1, 9, 3, 6, 5 };
/*
    int[] array1;
    int n = 4;
    array1 = new int[n];

      int[] array2 = new int[5] { 1, 9, 3, 6, 5 };

   // Console.WriteLine(array[4]);                                        // вывести элемент массива 2
  //  array[0] = 10;

    Console.WriteLine($"Last item in array: {array[array.Length - 1]}");                          // получение последнего элемента массива (1)
    Console.WriteLine($"Last item in array: {array[^2]}");                                        //  получение последнего элемента массива (2)=(1)
    Console.WriteLine($"Last item in array: {array[array.GetUpperBound(0)]}");                    // получение последнего элемента массива - лучше использовать его

   Console.WriteLine("Length: " + array.Length);                   // количество всех элементов
    Console.WriteLine("Rank: " + array.Rank);                           // ранк массива
    Console.WriteLine("GetLength(0): " + array.GetLength(0));           // количество строк
    Console.WriteLine("GetUpperBound(0): " + array.GetUpperBound(0));   // Верхний индекс строк - индекс первого элемента строки
    Console.WriteLine("GetUpperBound(0): " + array.GetLowerBound(0));   // Нижний индекс строк - индекс последнего элемента строки


    Console.WriteLine(array[0]); 
    Console.WriteLine(array[1]);
    Console.WriteLine(array[2]);
 */
// for (объявление переменной; условие; изменение переменной);

/*    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
    for (int i = 0; i <= array.GetUpperBound(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
*/


/*  int[] array = { 1, 9, 3, 6, 5 };

  Console.WriteLine();
  for (int i = 0; i <= array.GetUpperBound(0); i++)
  {
      array[i] = new Random().Next(100);
  }

  Console.WriteLine();
      foreach (int item in array)
  {
      Console.Write($"{item} ");
  }

  int[] arr1 = new int[6];
*/

// лекция 7


{
    /* Console.WriteLine("введите любое число:");
     string? digit_a= Console.ReadLine();*/

    /*    double x = 10.0;
        double z = x % 4;
         Console.WriteLine($"результат:{z}");

        double b = 10.0;
        double c = b % 2.0;
        Console.WriteLine($"результат:{c}");
    */



}


// массивы классная работа 21.11.202023
//     Трехмерный массив ============================================= -

/*    
    int[,,] array3D = new int[,,]
    {
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        },
        {
            { 7, 8, 9 },
            { 10, 11, 12 }
        }
    };


    Console.WriteLine("Length: " + array3D.Length);                       // количество всех элементов
    Console.WriteLine("Rank: " + array3D.Rank);                           // ранк массива
    Console.WriteLine("GetLength(0): " + array3D.GetLength(0));           // количество строк
    Console.WriteLine("GetUpperBound(0): " + array3D.GetUpperBound(0));   // Верхний индекс строк
    Console.WriteLine("GetLength(1): " + array3D.GetLength(1));           // количество столбцов
    Console.WriteLine("GetUpperBound(1): " + array3D.GetUpperBound(1));   // Верхний индекс столбцов
    Console.WriteLine("GetLength(2): " + array3D.GetLength(2));           // количество столбцов
    Console.WriteLine("GetUpperBound(2): " + array3D.GetUpperBound(2));   // Верхний индекс столбцов

    Console.WriteLine("GetLowerBound(0): " + array3D.GetLowerBound(0));   // Нижний индекс строк
    Console.WriteLine("GetLowerBound(1): " + array3D.GetLowerBound(1));   // Нижний индекс столбцов
    Console.WriteLine("GetLowerBound(2): " + array3D.GetLowerBound(2));   // Нижний индекс столбцов


      for (int i = 0; i <= array3D.GetUpperBound(0); i++)
      {
          Console.WriteLine($"-========= Level {i} ==========-");
          for (int j = 0; j <= array3D.GetUpperBound(1); j++)
          {
              for (int k = 0; k <= array3D.GetUpperBound(2); k++)
              {
                  Console.Write($"{array3D[i, j, k]} \t");
              }
              Console.WriteLine();
          }
          Console.WriteLine($"-============================-");
      }



// зубчаты массив
int[][] numbers =
{
    new int[] { 1, 2 },
    new int[] { 1, 2, 3, 4, 5 },
    new int[] { 1, 2, 3 }
};
    Console.WriteLine("Length: " + numbers.Length);                       // количество всех элементов
    Console.WriteLine("Rank: " + numbers.Rank);                           // ранк массива
    Console.WriteLine("GetLength(0): " + numbers.GetLength(0));           // количество строк
    Console.WriteLine("GetUpperBound(0): " + numbers.GetUpperBound(0));   // Верхний индекс строк



foreach (int[] row in numbers)
{
    for (int i = 0; i < row.Length; i++)
    {
        row[i] = new Random().Next(100);
    }
}

for (int i = 0; i <= numbers.GetUpperBound(0); i++)
{
    for (int j = 0; j <= numbers[i].GetUpperBound(0); j++)
    {
        Console.Write($"{numbers[i][j]} \t");
    }

    Console.WriteLine();
}
*/
// пример задачи на массивы "инверсия массивов" - перевернуть массив
/*
    int[] nums = { -4, 8, 10, 2, 12, 0, 5 }; // найти середину массива, затем двигаться от начала массива к середине

    foreach (int item in nums)
    {
        Console.WriteLine($"{item} \t");
    }
    Console.WriteLine();
   */
//     nums[0] <-> nums[nums.Length - 1 - 0]
//   nums[1] <->nums[nums.Length - 1 - 1]
// nums[2] <->nums[nums.Length - 1 - 2]


/*
 * int n = nums.Length; // длина массива
  int k = n / 2;
  int tmp;

  for (int i = 0; i < k; i++)
  {
      tmp = nums[i];
      nums[i] = nums[n - 1 - i];
      nums[n - 1 - i] = tmp;
  }
  foreach (int item in nums)
  { 
      Console.Write($"{item} \t");
  }
  //
  foreach (int item in nums)
  {
      Console.Write($"{item} \t");
  }
  Array.Reverse(nums);
  foreach (int item in nums)
  {
      Console.Write($"{item} \t");
  }



//StringApp

//
string message9;

// может содержать null, в отличие от int
string message8 = null;

// можем проинициализировать пустую строку
string message7 = System.String.Empty;

// можем проинициализировать строку с литералами ???
string oldPath = "c:\\Program Files\\tmp.txt";
string oldPath2 = @"c:\Program Files\tmp.txt"; // при проставленнии собаки система понимает спец.символы
string oldPath3 = @"c:\Program Files\""tmp"".txt";

//
System.String greeting = "Hello World!";
String greeting2 = "Hello World!";
var greeting3 = "Hello World!";
const string greeting4 = "Hello World!";


string s2 = new string('a', 6); //результат - строка "аааааа"

// Declare without initializing.
string message1;

// Initialize to null.
string message6 = null;

// Initialize as an empty string.
// Use the Empty constant instead of the literal "".
string message17 = System.String.Empty;

// Initialize with a regular string literal.
string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

// Initialize with a verbatim string literal.
string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

// Difference
string filePath = @"C:\Users\scoleridge\Documents\""Test""\";
string filePath1 = "C:\\Users\\scoleridge\\Documents\\\"Test\"";

// Use System.String if you prefer.
System.String greeting = "Hello World!";

// In local variables (i.e. within a method body)
// you can use implicit typing.
var temp = "I'm still a strongly-typed System.String!";

// Use a const string to prevent 'message4' from
// being used to store another string value.
const string message4 = "You can't get rid of me!";

// Use the String constructor only when creating
// a string from a char*, char[], or sbyte*. See
// System.String documentation for details.
char[] letters = { 'A', 'B', 'C' };
string alphabet = new string(letters); // соответствует s3

string s1 = "hello";
string s2 = new String('a', 6); // результатом будет строка "aaaaaa"
string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3); // orl

Console.WriteLine(s1);  // hello
Console.WriteLine(s2);  // aaaaaaa
Console.WriteLine(s3);  // world
Console.WriteLine(s4);  // orl


string msg3 = "hello\0";  // скрытый символ
string msg2 = "hello";
string msg1 = "hello";


Console.WriteLine(msg3);  // скрытый символ не виден
Console.WriteLine(msg1 == msg2);  // сравнение строк посимвольно
Console.WriteLine(msg1.Equals(msg2));
Console.WriteLine(msg1[0]);

foreach (char c in msg1)  //выводит строку посимвольно
{
    Console.WriteLine(c);
}

string s11 = "A string is more ";
string s21 = "than the sum of its chars.";

Console.WriteLine(s11.GetHashCode());

//конкотинация двух строк: третья строка на основании двух других

string s31 = s11 + s21;
Console.WriteLine(s31);
//таже конкатинация
s11 +=  s21;
Console.WriteLine(s11);
Console.WriteLine(s11.GetHashCode());


string text = """
               < element attr="content">
               <body>
               </body>
               </element>
               """;
Console.WriteLine(text);

int val = 10;
string text_inter = $"""
                      <element attr="content">
                        <body>
                        {val}
                        </body>
                      </element>
                      """;
string text1 = "<element attr=\"content\">" +
               "<body>" +
               "</body>" +
               "</element>";
Console.WriteLine(text);
Console.WriteLine(text_inter);
Console.WriteLine(text1);
*/

string s5 = "apple";
string s6 = "a day";
string s7 = "keeps";

string[] values = new string[] { s5, s6, s7 };   //массив
string str_final = string.Join(" : ", values); //объединение значений массива

Console.WriteLine(str_final);







