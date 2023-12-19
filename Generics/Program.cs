// See https://aka.ms/new-console-template for more information

using Generics;
/*
SimplePerson simplePerson = new SimplePerson(546, "Tom");
ObjectPerson objectPerson = new ObjectPerson("abc123", "Bob");  // меняем тип параметра id - вместо int используем object

int tomId = simplePerson.Id;
string bobId = (string)objectPerson.Id; // опасная ситуация: не всегда можно привести один тип к другому

Console.WriteLine($"Tom ID: {tomId}");
Console.WriteLine($"Bob ID: {bobId}");


ObjectPerson objectPerson1 = new ObjectPerson(123, "Bob"); // упаковка значения int в тип Object
int intBobId = (int)objectPerson1.Id; // Распаковка в тип int
// string strBobId = (string)objectPerson1.Id;                  // Ошибка при выполнении: int нельзя привести в тип string
// упаковка и распаковка отнимают память и ресурсы
*/

// -=================== Generics ===================- 
GenericPerson<int> intPerson = new GenericPerson<int>(123, "Alex");  // здесь уже указываем конкретно тип int и тогда все Т заменятся на int
int intAlexId1 = intPerson.Id;
intPerson.Print();

// -=================== Варианты
GenericPerson<string> strPerson = new GenericPerson<string>("- 123 -", "Alex"); // а в данном случае мы вместо Т подставляем string
GenericPerson<Guid> uniquePerson = new GenericPerson<Guid>(Guid.NewGuid(), "Alex");  // тип guid  - уникальный ключ вида ID: 75a01f38-1faf-490b-8efb-3fccff061b4f,
uniquePerson.Print();

int intAlexId = intPerson.Id;
string strAlexId = strPerson.Id;
// В обоих случаях не нужна раскаковка и упаковка

Company<GenericPerson<Guid>> mtCompany2 = new Company<GenericPerson<Guid>>(uniquePerson);  //
Company<GenericPerson<int>> mtsCompany = new Company<GenericPerson<int>>(intPerson);
Company<GenericPerson<string>> mtsCompany1 = new Company<GenericPerson<string>>(strPerson);


// -=================== Static
// StaticPerson.code = 123; // Ошибка - отсутствует типизация (не прописан тип)
StaticPerson<int>.code = 123;
StaticPerson<string>.code = "- 123 -";

Console.WriteLine(StaticPerson<int>.code);
Console.WriteLine(StaticPerson<string>.code);

// -=================== Несколько обобщенных типов
Person<Guid, string> alex = new Person<Guid, string>(Guid.NewGuid(), "wp", "Alex");
Person<Guid, int> olga = new Person<Guid, int>(Guid.NewGuid(), 1, "Olga");


// -=================== Обобщенные методы
int x = 10;
int y = 15;
Helper.Swap<int>(ref x, ref y);

string x1 = "10";
string y1 = "15";
Helper.Swap<string>(ref x1, ref y1);


// -========================================================================== Ограничения Generics ===================-
// -============================================================================ Ограничения методов
Helper.SendMessage(new Message("Bye World"));
//Helper.SendMessage(new EmailMessage("Bye World"));
Helper.SendMessage(new EmailMessage("This is Email message..."));

Helper.SendMessage<EmailMessage>(new EmailMessage("Bye World"));
Helper.SendMessage<SmsMessage>(new SmsMessage("This is Sms message..."));



// -============================================================================= Ограничения обобщений в типах
Messenger<Message> telegram = new Messenger<Message>();
telegram.SendMessage(new Message("Hello World"));

Messenger<EmailMessage> outlook = new Messenger<EmailMessage>();
outlook.SendMessage(new EmailMessage("Bye World"));

MessengerStruct<MessageStruct> messengerStruct = new MessengerStruct<MessageStruct>();
MessengerStruct<int> test1 = new MessengerStruct<int>(); // 
// MessengerStruct<Message> // Ошибка - class не struct
messengerStruct.SendMessage(new MessageStruct("Struct is cool for small objects..."));

MessengerClass<SmsMessage> smsMessengerClass = new MessengerClass<SmsMessage>();
// MessengerClass<int> // Ошибка
// MessengerClass<string> // string = class  
smsMessengerClass.SendMessage(new SmsMessage("SMS is not actual anymore..."));

// MessengerNew<SmsMessage> nMessengerNew = new MessengerNew<SmsMessage>(); // Ошибка потому что у SmsMessage нет конструктора без параметров 
MessengerNew<EmailMessage> nMessengerNew = new MessengerNew<EmailMessage>(); // Все ок

// -==================================================================================== Ограничения нескольких универсальных параметров
SimplePerson sender = new SimplePerson(1, "Ted");
SimplePerson receiver = new SimplePerson(3, "Fred");
MessengerService<EmailMessage, SimplePerson> messengerService = new MessengerService<EmailMessage, SimplePerson>();
messengerService.SendMessage(sender, receiver, new EmailMessage("Email..."));


// -=================== Наследование обобщенных типов
ChildGenericPerson<Guid> childGenericPerson = new ChildGenericPerson<Guid>(Guid.NewGuid(), "Toma");
IntGenericPerson intGenericPerson = new IntGenericPerson(1, "Vera");
VaryGenericPerson<string> varyGenericPerson = new VaryGenericPerson<string>(2, "Gena");
ChildWherePerson<string> childWherePerson = new ChildWherePerson<string>("1/2", "Dolly");
ChildWherePerson<SimplePerson> childWherePerson1 =
    new ChildWherePerson<SimplePerson>(new(3, "Sam"), "Dolly");
