using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    internal class Car
    {
        //khai bao cac truong voi pham vi public
        public string make;
        public string model;
        public string color;
        public int year;
        // dinh nghia phuong thuc start
        public void Start()
        {
            System.Console.WriteLine(model + "khoi dong");
        }
        //dinh nghia phuong thuc stop
        public void Stop()
        {
            System.Console.WriteLine(model + "dung");
        }
    }
}
