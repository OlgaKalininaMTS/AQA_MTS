
using Delegate;


/////////////////////////////////////////////////// Домашняя работа Задание 1
//new Exercise1().RunNum();

/////////////////////////////////////////////////// Домашняя работа Задание 2
FormulaClass formulaClass = new FormulaClass();
Exercise2 circumference = formulaClass.Circumference;
Exercise2 areaCircle = formulaClass.AreaCircle;
Exercise2 volumeBall = formulaClass.VolumeBall;

double circum = circumference(1.2);
double area = areaCircle(4.3);
double volume = volumeBall(7.8);

//Console.WriteLine(return);