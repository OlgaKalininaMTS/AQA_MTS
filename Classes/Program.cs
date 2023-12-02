using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Classes.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            // 1 экземпляр класса Phone с конструктором 1
            Phone tom1 = new Phone();

            // 1 экземпляр класса Phone с конструктором 1
         /*   Phone tom2 = new Phone(89049049904, 01);
            { 
            
            }

*/





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


        }
    }
}