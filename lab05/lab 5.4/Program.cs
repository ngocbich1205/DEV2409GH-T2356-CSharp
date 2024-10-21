namespace lab_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Programming with Csharp",4);
            //nhap thong tin cac chuong
            b[0] = new Chapter("Chapter 1", "Intoduction to Csharp");
            b[1] = new Chapter("Chapter 2", "DataType and Variables in Csharp");
            b[2] = new Chapter("Chapter 3", "Input and Output in Console Application");
            b[3] = new Chapter("Chapter 4", "Statements Conditions and Loops");
            //in thong tin sach
            Console.WriteLine("List of book:");
            Console.WriteLine(b.Name);
            //danh sach chuong
            for (int i = 0;i<4;i++)
            {
                Console.WriteLine(b[i]);
            }
            //thong tin chuong 3
            Console.WriteLine("Detail of Chapter 3");
            Console.WriteLine(b["Chapter 3"]);
            Console.Read();
        }
    }
}
