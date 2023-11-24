// See https://aka.ms/new-console-template for more information
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

 
   int[] array = { 1, 9, 3, 6, 5 };

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


