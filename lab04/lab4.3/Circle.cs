﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._3
{
    internal class Circle : Shape
    {
        public void InputData()
        {
            Console.Write("Nhap ban kinh:");
            radius = int.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return 3.14F * radius * radius;
        }
        public override float Circumference()
        {
            return 2*3.14F*radius;
        }
    }
}
