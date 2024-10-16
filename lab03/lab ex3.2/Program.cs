namespace lab_ex3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
             Book b1=new Book();
             Book b2 = new Book("Trần Ngọc Bích", 10, "VN", "Đứa con của gió", 30);
            b1.Display();
            b2.Display();

            b1.flipPageForWard();
            b2.flipPagesBackward();
            Console.ReadKey();
        }
    }
}
