using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._4
{
    internal class Utility
    {
        //khong su dug ref
        public void SwapFake(int a, int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }
        //su dung ref cho tham so
        public void SwapReally(ref int a, ref int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }
        //su dung out cho tham so
        public void AreaCircle(double radius, out double area)
        {
            area = 2* Math.PI* radius;
        }
    }
}
