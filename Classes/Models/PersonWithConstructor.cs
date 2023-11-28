namespace Classes.Models;

public class PersonWithConstructor
{
    // Блок полей (переменных)
    public string name = "Undefined";   // имя
    public int age;                     // возраст
    public int surname;                     // фамилия


    public PersonWithConstructor()
    {
        name = "Undefined";   // имя
        age = 1;
}

    // Блок конструктора

    // Блок методов и свойств
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}