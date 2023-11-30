using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Student
    {
        public string name;
        public int group;
        public int diplomMark;

        public Student()
        { 
        
        }

        public Student(string name)
        {
            this.name = this.name;
            group = 1;
            diplomMark = new Random().Next();
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Group: {group}, Mark: {diplomMark}");
            Console.WriteLine();

        }
    }
}
