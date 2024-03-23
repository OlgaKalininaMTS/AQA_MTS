
using Delegate;
using System;
using System.Drawing;
using System.Numerics;
//using static Delegate.Exercise3;
using static System.Runtime.InteropServices.JavaScript.JSType;


/////////////////////////////////////////////////// Домашняя работа Задание 1
//new Exercise1().RunNum();

Exercise1 metodDeleg = new Exercise1();
Exercise1.Num num = new Exercise1.Num(metodDeleg.RunNum);
Console.WriteLine($"Случайное число: {num()}");

/////////////////////////////////////////////////// Домашняя работа Задание 2

FormulaClass formula = new FormulaClass();
Exercise2 circumference = formula.Circumference;
Exercise2 areaCircle = formula.AreaCircle;
Exercise2 volumeBall = formula.VolumeBall;

double radius = 5;

Console.WriteLine($"Длина окружности: {circumference(radius)}");
Console.WriteLine($"Площадь круга: {areaCircle(radius)}");
Console.WriteLine($"Объем шара: {volumeBall(radius)}");

/////////////////////////////////////////////////// Домашняя работа Задание 3
/*
static void Main(string[] args)
{
    int[] randomArray = GenerateRandomArray(8); // создаем массив из 8 чисел
    Console.WriteLine("Исходный массив:");
    PrintArrayRun(randomArray);

    TypeSorting typesorting = (TypeSorting)new Random().Next(0, 2); // выбираем тип сортировки
    SortArrayDelegate sortingDelegate = TypeSort.GetSelectSortMetDelegate(typesorting);
    int[] sortedArray = sortingDelegate(randomArray);

    Console.WriteLine($"Массив отсортирован методом сортировки {typesorting}:");
    PrintArrayRun(sortedArray); //вывод сортированного массива в виде строки
} 
     
    static int[] GenerateRandomArray(int size)   // Генерация случайного массива состоящий из 10 чисел от 0 до 100
    {
        var random = new Random();
        int[] runArray = new int[size];
        for (int i = 0; i < size; i++)           //runArray.Length; i++)
        {
            // runArray[i] = new Random().Next(100);
            runArray[i] = random.Next(100);
        }
        return runArray;
    }
    static void PrintArrayRun(int[] runArray)
    {
        Console.Write("[");
        for (int i = 0; i < runArray.Length; i++)
        {
            Console.Write(runArray[i]);
            if (i < runArray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
*/

