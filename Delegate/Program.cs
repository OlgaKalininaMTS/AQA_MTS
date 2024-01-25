
using Delegate;


/////////////////////////////////////////////////// Домашняя работа Задание 1
//new Exercise1().RunNum();

/////////////////////////////////////////////////// Домашняя работа Задание 2
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