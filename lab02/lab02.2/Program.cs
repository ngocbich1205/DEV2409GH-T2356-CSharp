namespace lab02._2
{
    /// <summary>
    /// Nhập vào 1 ký tự, in ra ký tự đó là nguyên âm hay phụ âm
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Nhap vao ky tu:");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i':Console.WriteLine("{0}la nguyen am.",ch);
                    break;
                    default: Console.WriteLine("{0} la phu am.", ch);
                    break;
            }
        }
    }
}
