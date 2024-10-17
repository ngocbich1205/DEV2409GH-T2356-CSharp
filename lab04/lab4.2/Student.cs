﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    abstract class Student
    {
        protected string name;
        protected int year;
        //phuong thuc khoi tao
        public Student(string name, int year)
        {
            this.name = name;
            this.year = year;
        }
        protected void Display()
        {
            Console.WriteLine("Name:{0}", name);
            Console.WriteLine("Year:{0}", year);
        }
        public abstract double Average();
    }
}
