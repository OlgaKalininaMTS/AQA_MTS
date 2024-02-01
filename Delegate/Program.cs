
using Delegate;
using System;
using System.Drawing;
using System.Numerics;
using static Delegate.Exercise3;
using static System.Runtime.InteropServices.JavaScript.JSType;


/////////////////////////////////////////////////// Домашняя работа Задание 1
//new Exercise1().RunNum();

/////////////////////////////////////////////////// Домашняя работа Задание 2
/*
FormulaClass formula = new FormulaClass();
Exercise2 circumference = formula.Circumference;
Exercise2 areaCircle = formula.AreaCircle;
Exercise2 volumeBall = formula.VolumeBall;

double circum = circumference(2);
double area = areaCircle(7);
double volume = volumeBall(3);

Console.WriteLine($"Длина окружности: {circum}");
Console.WriteLine($"Площадь круга: {area}");
Console.WriteLine($"Объем шара: {volume}");
*/
/////////////////////////////////////////////////// Домашняя работа Задание 3
static void Main(string[] args)
{
  //  int[] randomArray = GenerateRandomArray(int size); // создание массива из 10 случайных чисел с помощью метода GenerateRandomArray
  //  Console.WriteLine("Исходный массив:");
   

    static int[] GenerateRandomArray(int size)   // Генерация случайного массива состоящий из 10 чисел от 0 до 100
    {
        int[] runArray = new int[10];
        for (int i = 0; i < runArray.Length; i++)
        {
            runArray[i] = new Random().Next(100);
        }
        return runArray;
    }

   
        int[] randomArray = GenerateRandomArray(10); // создание массива из 10 случайных чисел с помощью метода GenerateRandomArray
        Console.WriteLine("Исходный массив:");
        PrintArray(randomArray); //вывод на экран созданного массива

        TypeSorting sortingType = (TypeSorting)new Random().Next(0, 2); //выбор случайным образом тип сортировки из SortingType
    SortArray sortingDelegate = Exercise3.SelectSortMet(numbers); //инстанцируем экземпляр делегата с ссылкой на метод сортировки
        int[] sortedArray = sortingDelegate(randomArray); //вызов делегата

        Console.WriteLine($"Отсортированный массив с использованием {array}:");
        PrintArray(sortedArray); //вывод сортированного массива в виде строки

    static void PrintArray(int[] array) //метод печати массива на экран
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }


}