using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class ListBox : Window
    {
        //khai bao truong moi
        private string listBoxContents;
        public ListBox(int top, int left, string contents) : base(top, left)
        {
            listBoxContents = contents;
        }
        // ghi de phuong thuc DrawWindow
        public override void DrawWindow()
        {
            base.DrawWindow();//goi phuong thuc lop co so
            Console.WriteLine("Writing string to the listbox:{0}", listBoxContents);
        }
    }
}
