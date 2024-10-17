using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class Window
    {
        protected int top;
        protected int left;
        //phuong thuc khoi tao
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        //phuong thuc vỉtual vẽ cửa sổ
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0},{1}",top,left);

        }
    }
}
