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
            
         
            /*
                        // 1 экземпляр класса Phone с методом Print
                        Phone tom4 = new Phone();

                        tom4.number = 5;
                        tom4.model = 15;
                        tom4.weight = 55;      

                        tom4.Print();

                        // 2 экземпляр класса Phone с методом receiveCall
                        Phone tom5 = new Phone();

                        tom5.receiveCall("Olga");

                        // 3 экземпляр класса Phone с методом getNumber
                        Phone tom6 = new Phone();

                        tom6.getNumber(101010);
            */

        }
    }
}