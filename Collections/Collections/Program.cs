using Collections;
using System.Collections;


//////////////////////////////// Домашняя работа по Collection. Задание 3

string numString = "1, 2, 3, 4, 4, 5";
Console.WriteLine($"Изначальная коллекция: {numString}");

/*
string[] numСollection = numString.Split(", ");
string[] uniqueNumbersArray = numСollection.Distinct().ToArray();
string newnumСollection = string.Join(", ", uniqueNumbersArray);

// Вывод результата на экран
Console.WriteLine($"Коллекция после удаления повторяющихся чисел: {newnumСollection}");
*/
new DictionaryProducts().Run();