// See https://aka.ms/new-console-template for more information

// Домашняя работа по теме "Символы и строки"
using System.Text;
using System.Text.RegularExpressions;

namespace Strings_hw // Примечание. Фактическое пространство имен зависит от названия проекта
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Задание 1

            string str1 = "test one1, test two2, test three3";
            string replacedString1 = str1.Replace("test", "testing");
            Console.WriteLine($"Строка после замены: {replacedString1}");

            var res = replacedString1.ToCharArray().Where(n => !char.IsDigit(n)).ToArray();
            Console.WriteLine($"Строка после замены: {new string(res)}");


            // Задание 2

            string s1 = "Welcome ";
            string s2 = "to ";
            string s3 = "the ";
            string s4 = "TMS ";
            string s5 = "lesons.";

            string result = string.Concat(s1, s2, s3, s4, s5);
            Console.WriteLine($"Результат конкатенации: {result}");


            // Задание 3

            string str = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
            string ch = "abc";
            int startAbc = str.IndexOf(ch); 
            Console.WriteLine(startAbc);

            string substring1 = str.Remove(startAbc);
            Console.WriteLine($"Символы до \"abc\": {substring1}");

            string substring2 = str.Substring(startAbc + ch.Length);  
            Console.WriteLine($"Символы после \"abc\": {substring2}");


            // Задание 4

            string day1 = "Плохой день.";
            Console.WriteLine($"Начальная строка: {day1}");

            char[] chars2 = { ' ' };
            int res4 = day1.IndexOfAny(chars2);
            string substring14 = day1.Substring(res4);  
            //  Console.WriteLine($"Из фразы \"{day1}\" удалили слово \"Плохой\": {substring1}");

            string insertedAtStart = substring1.Insert(0, "Хороший");
            //  Console.WriteLine($"Добавили слово \"Хороший\" (в начале): {insertedAtStart}");

            string insertedAtEnd = insertedAtStart.Insert(insertedAtStart.Length - 1, "!!!!!!!!!"); 
            //  Console.WriteLine($"Insert (в конце): {insertedAtEnd}");

            string hhh = insertedAtEnd.Remove(insertedAtEnd.Length - 2);
            //  Console.WriteLine(hhh);

            string www = hhh.Insert(hhh.Length, "?."); 
            Console.WriteLine($"Итоговая строка: {www}");

        }

    }

}
