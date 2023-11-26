using System.Security.Cryptography.X509Certificates;
using Classes.Models;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашняя работа по теме "Методы и классы"


            int[] array = { 1, 8, 14, -4, 0, 7 };
              foreach (var item in array)
              {
                  Console.Write($"{item}\t");
              }
              Console.WriteLine();

              Array.Reverse(array);
              {
                  foreach (var item in array)
                  {
                      Console.Write($"{item}\t");
                  }

                  Console.WriteLine();
              }
              ////////////////////////////////////////////////////////////////////////////////////////
              PrintArray(array);  // обозначаем что создаем метод

              void PrintArray(int[] arr)
              {                          // void - ничего не возвращается, поэтому не используется return
                  foreach (var item in arr)
                  {
                      Console.Write($"{item}\t");
                  }

                  Console.WriteLine();
              }


        }
    }
}