using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_ex3._2
{
    internal class Book
    {
        // Các thuộc tính
        public string Author { get; set; }
        public int Pages { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int CurrentPage { get; set; }

        // Constructor mặc định
        public Book()
        {
            Author = "";
            Pages = 0;
            ISBN = "";
            Title = "";
            CurrentPage = 1;
        }

        // Constructor có tham số
        public Book(string author, int pages, string isbn, string title,int CurrentPage)
        {
            Author = author;
            Pages = pages;
            ISBN = isbn;
            Title = title;
            CurrentPage = 1; // Trang mặc định là 1 khi khởi tạo
        }
        public void Display()
        {
            Console.WriteLine("tác giả: " + Author);
            Console.WriteLine("trang: " + Pages);
            Console.WriteLine("isbn:" + ISBN);
            Console.WriteLine("Tiêu đề: " + Title);
            Console.WriteLine("Trang hiện tại: " + CurrentPage);
        }
        public void flipPageForWard()
        {
            Console.WriteLine("Lật sang trang trước!");
        }
        public void flipPagesBackward()
        {
            Console.WriteLine("Lật sang trang sau");
        }
    }

 
   

}

