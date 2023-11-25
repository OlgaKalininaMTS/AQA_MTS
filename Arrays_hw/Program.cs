// See https://aka.ms/new-console-template for more information

// Домашняя работа по теме "Циклы и массивы"

// Задача 1

Console.WriteLine("Введите любое число :");
int a1 = Convert.ToInt32(Console.ReadLine());
int b1 = 0;
int[] array1 = { 1, 9, 3, 6, 5 };
foreach (int i in array1)
{
    if (i == a1)
    {
       Console.WriteLine($"Веденное число входит в массив");
        b1 = 1;
    }
 }
if (b1 == 0)
{
    Console.WriteLine($"Веденное число не входит в массив");
}


// Задача 2

Console.WriteLine("Введите любое число :");
int a = Convert.ToInt16(Console.ReadLine());

int[] array2 = { 99, 12, 78, 45, 3, 15, 94, 4, 67, 9, 74, 32 };
var rr = new List<int>(array2.GetLength(0));
foreach (var i in array2)
    rr.Add(i);
//var tmp = new List<int>() { 99, 12, 78, 45, 3, 15, 94, 4, 67, 9, 74, 32 }; // Преобразование в список

if (rr.Remove(a))
{
    Console.WriteLine("Введенное число содержится в массиве и было удалено");
    var b = rr.ToArray(); // Преобразование в массив
    var str2 = string.Join(" ", b);
    Console.WriteLine(str2);
}
else 
{
    Console.WriteLine("Введенное число не содержится в массиве и не было удалено");
    var str = string.Join(" ", array2);
    Console.WriteLine(str);
}

// Задача 3

Console.WriteLine("Введите размер массива (число от 0 до 100):");
int ab = Convert.ToInt16(Console.ReadLine());

int[] array3 = new int[ab];
Random rand = new Random();
for (int i = 0; i < array3.Length; i++)
    array3[i] = rand.Next(100);

Console.WriteLine();
foreach (int item in array3)
{
    Console.Write($"{item} ");
}

int max = array3.Max();
Console.Write($"\n Максимальное значение массива: {max}");

int min = array3.Min();
Console.Write($"\n Минимальное значение массива: {min}");

int summ = 0;
for (int i = 0; i < array3.Length; i++)
    summ += array3[i];
int aver = summ / array3.Length;
Console.WriteLine($"\n Среднее значение массива: {aver}");

// Задача 4

int[] spi14 = { 5, 4, 3, 2, 1 };  //3
var str14 = string.Join(" ", spi14);

int[] spi24 = { 5, 4, 100, 2, 1 };  //8
var str24 = string.Join(" ", spi24);

Console.WriteLine($"Массив 1:{str14}\nМассив 2:{str24}");

// среднее арифметическое массива 1
int summ4 = 0;
for (int i = 0; i < spi14.Length; i++)
    summ4 += spi14[i];
int mid = summ4 / spi14.Length;
Console.WriteLine($"Среднее арифметическое массива 1: {mid}");

// среднее арифметическое массива 2
int summ2 = 0;
for (int i = 0; i < spi24.Length; i++)
    summ2 += spi24[i];
int mid2 = summ2 / spi14.Length;
Console.WriteLine($"Среднее арифметическое массива 2: {mid2}");

if (mid > mid2)
{
     Console.WriteLine("Среднее арифметическое массива 1 больше среднего арифметического массива 2");
}
if (mid < mid2)
{
     Console.WriteLine("Среднее арифметическое массива 1 меньше среднего арифметического массива 2");
}
if (mid == mid2)
{
     Console.WriteLine("Средние арифметические массива 1 и массива 2 равны");
}





