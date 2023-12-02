namespace Properties;

public class Person
{
    private string name;
    private string surname;
    private int age;
    private string address;
    private bool isMan;
    private int weight;

    public Person()
    { 
    
    }


    // Стандартный вариант работы с блоком данных
    public void SetName(string name)    // 
    {
        // Какая-то логика
        this.name = name;
    }

    public string GetName()      //
    {
        // Какая-то логика
        return name;
    }
    
    // В C# есть Свойство для доступа к полю name
    public string Name     // это Свойство
    {
        get      // в get обязательно д.б. return
        { 
            return name; 
        }
        set                                   
        {
            // Логика проверки при установке значения
            if (!string.IsNullOrEmpty(value))    // 
            {
                name = value;                 // единичный параметр который передается данному свойству
            }
        }
    }
    
    // свойство только для записи
    public int Age   // значение устанавливается, но не используется
    {
        set { age = value; }
    }
    
    // свойство только для чтения
    public string Surname
    {
        get { return surname; }
    }
    
    // Вычисляемые свойства
    public string Fullname
    {
        get { return  $"{name} {surname}"; }
    }
    
    // Модификаторы доступа
    public string Address
    {
        get { return address; }
 
        private set { address = value; }
    }
    
    // Автоматические свойства
    //public int Salary { get; set; }
   //  public int Salary { get; set; } = 12500;
     public int Salary { get; private set; }   // можем прописать права для какого-то параметра
    
    // Блок init
    // Первый способ
  //  public string ID { get; init; } = "XXX-712";  //
    
    // Второй способ
  //public Person(string id) => ID = id; 
    // Или так
    /*
    public Person(string id)
    {
        ID = id;
    }
    */
    
    // Третий способ
    // В Program.cs
    
    // Сокращенная запись свойств
    public bool IsMen 
    { 
        get => isMan;
        set => isMan = value; 
    }
    public int Weight => weight;
 
    // Модификатор required
    //public required string Passport { get; set; } // - Ошибка при вызове базового конструктора
    /*
    public Person(string passport)
    {
        Passport = passport;
    }
    */

}