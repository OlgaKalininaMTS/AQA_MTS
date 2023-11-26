namespace Classes.Models;

public class Phone
{
    // Блок полей (переменных)
    public int number;   // номер
    public int model;      // возраст
    public int weight;    // вес
    

    // Блок конструктора

    // Блок методов и свойств
    public void Print()
    {
        Console.WriteLine($"Имя: {number}  Возраст: {model} Возраст: {weight}");
    }
}