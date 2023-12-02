using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашняя работа по теме "Методы и классы"

            //Задание 1

            // экземпляр класса с конструктором 1
           PhoneConstructor1 tom1 = new PhoneConstructor1();
           tom1.Print();


            // экземпляр класса с конструктором 2
            PhoneConstructor2 tom2 = new PhoneConstructor2(number: "8-999-99-999-99", model:"samsung");
            tom2.Print();

            // экземпляр класса с конструктором 3
            PhoneConstructor3 tom3 = new PhoneConstructor3(number: "8-999-99-999-99", model: "samsung", weight:200);
            tom3.Print();

            // экземпляр класса Phone с методом receiveCall
            Phone tom5 = new Phone();
            tom5.receiveCall("Olga");


            // экземпляр класса Phone с методом getNumber
            Phone tom6 = new Phone();
            tom6.getNumber("8-999-99-999-99");

            //экземпляр класса Phone с методом sendMessage 
            Phone tom7 = new Phone();
            tom7.sendMessage("8-999-99-999-99", "8-999-99-333-99");

            Phone tom8 = new Phone();
            tom7.sendMessage("8-999-99-999-99", "8-999-99-333-99", "8-999-99-333-99", "8-999-99-222-99", "8-999-99-111-99");

            

            // Задание 2
           
            CreditCard card = new CreditCard();
            CreditCard card2 = new CreditCard();
            CreditCard card3 = new CreditCard();

            Random rand = new Random();
            int value = rand.Next(111111111, 999999999);
            card.AccountNumber = value;
                      
            value = rand.Next(9999);
            card.Accountsumma = value;

            value = rand.Next(111111111, 999999999);
            card2.AccountNumber = value;

            value = rand.Next(9999);
            card2.Accountsumma = value;

            value = rand.Next(111111111, 999999999);
            card3.AccountNumber = value;

            value = rand.Next(9999);
            card3.Accountsumma = value;

            card.SimpleInfo();
            card2.SimpleInfo();
            card3.SimpleInfo();

           // card.SimpleAdd(500);
          //  card2.SimpleAdd(350);
          //  card3.SimpleSub(480);
            
            card.SimpleInfo();
            card2.SimpleInfo();
            card3.SimpleInfo();

        }
    }
}