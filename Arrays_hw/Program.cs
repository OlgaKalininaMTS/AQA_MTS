// See https://aka.ms/new-console-template for more information

// Домашняя работа
// Задача 1

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

