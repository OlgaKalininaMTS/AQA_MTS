
using Delegate;
using System;
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
    int[] randomArray = GenerateRandomArray(); // создание массива из 10 случайных чисел с помощью метода GenerateRandomArray
    Console.WriteLine("Исходный массив:");
   

    static int[] GenerateRandomArray()   // Генерация случайного массива состоящий из 10 чисел от 0 до 100
    {
        int[] nums = new int[10];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = new Random().Next(100);
        }
        return nums;
    }


    

    
}