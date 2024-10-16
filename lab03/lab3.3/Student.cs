using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._3
{
    internal class Student
    {
        //tao cac thuoc tinh tu dong
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //phuong thuc hien thi
        public void Display()
        {
            Console.WriteLine("Id:" + Id);
            Console.WriteLine("Name:" +Name);
            Console.WriteLine("Age:" +Age);
        }
    }
}
