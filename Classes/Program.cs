using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Classes.Models;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            class Phone
            {
               public int number;
               public int model;
               public int weight;
               public void Print()
               {
                Console.WriteLine($"Номер: {number}  Модель: {model} Вес: {weight}");
               }
         }
       
        


        }
    }
}