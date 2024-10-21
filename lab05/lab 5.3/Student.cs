using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5._3
{
    internal class Student
    {
        string[] names;
        double[,] marks;
        //phuong thuc khoi tao
        public Student(int n, int m)
        {
            names = new string[n];
            marks = new double[n, m];
        }
        // chi muc don
        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
        //chi muc kep
        public double this[int i, int j]
        {
            get { return marks[i, j]; }
            set { marks[i, j] = value; }
        }
    }
}
