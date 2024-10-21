using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5._4
{
    public class Chapter
    {
        private string name;
        private string content;
        //constructor khong tham so
        public Chapter()
        {
            name = "";
            content = "";
        }
        //constructor co tham so
        public Chapter(string name, string content)
        {
            this.name= name;
            this.content = content;
        }
        // dinh nghia cac thuoc tinh
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public override string ToString()
        {
            return name + "\n " + content;
        }
    }
}
