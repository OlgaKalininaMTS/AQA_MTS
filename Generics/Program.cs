// See https://aka.ms/new-console-template for more information

using Generics;
using System;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Задание 1

Point<int> intPoint = new Point<int>(123, 456);  // вывод координат
intPoint.Print();

Point<double> intPointDouble = new Point<double>(12.8, 45.6);  // вывод координат
Console.WriteLine("Точки координа на плоскости: ");
intPoint.Print();

Point<Guid> uniquePoint = new Point<Guid>(Guid.NewGuid(), Guid.NewGuid());  // в качестве значения координат тип guid 
uniquePoint.Print();

Random ranPoint = new Random();  // в качестве значения координат рандомное число 
Point<int> pointRan = new Point<int>(ranPoint.Next(0,100), ranPoint.Next(0, 100));
pointRan.Print();

// Задание 2

GenericsArray<int> arrayNew = new GenericsArray<int>();
Random random = new Random();

for (int i = 0; i < 5; i++)
{
    int randNumber = random.Next(1, 100);
    arrayNew.Add(randNumber);
}

Console.WriteLine("Изначальный массив:");
arrayNew.PrintArray();

arrayNew.Add(2);
arrayNew.Add(4);
arrayNew.Add(8);
arrayNew.Add(13);
arrayNew.Add(7);

Console.WriteLine("Массив после добавления элементов:");
arrayNew.PrintArray();

Console.WriteLine();
arrayNew.Remove(4);
Console.WriteLine("Массив после удаления 5 элемента (с индексом 4):");
arrayNew.PrintArray();

Console.WriteLine();
var el = arrayNew.GetElement(5);
Console.WriteLine($"Элемент с индексом 5: {el}");

Console.WriteLine();
Console.WriteLine($"Длина массива: {arrayNew.GetLength()}");