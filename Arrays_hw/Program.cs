// See https://aka.ms/new-console-template for more information

// Домашняя работа
// Задача 1
/*
Console.WriteLine("Введите любое число :");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int[] array = { 1, 9, 3, 6, 5 };
foreach (int i in array)
{
    if (i == a)
    {
       Console.WriteLine($"Веденное число входит в массив");
        b = 1;
    }
 }
if (b == 0)
{
    Console.WriteLine($"Веденное число не входит в массив");
}
*/

// Задача 2
/*
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
*/

// Задача 3
int[] spi1 = { 1, 2, 3, 4, 5 };
var str1 = string.Join(" ", spi1);
Console.WriteLine(str1);
int[] spi2 = { 6, 7, 8, 9, 10 };
var str2 = string.Join(" ", spi2);
Console.WriteLine(str2);


