using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._3
{
    internal class Rectangle : Shape
    { 
        public void Inputdata()
        {
            Console.Write("Nhap chieu dai:");
            length = int.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong:");
            width = int.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return length * width;
        }
        public override float Circumference()
        {
           return 2*length*width;
        }
    }
}
