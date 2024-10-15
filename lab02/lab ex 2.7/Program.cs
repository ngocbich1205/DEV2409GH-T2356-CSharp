namespace lab_ex_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // xác định số hàng cho hình chóp
            int rows = 10;

            for (int i = 1; i <= rows; i++)
            {
                // in các khoảng trắng ở đầu để căn chỉnh
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                // in ra phần tăng dần của các số 
                for (int j = 0; j < i; j++)
                {
                    Console.Write((i + j) % 10);
                }

                // in phần giảm dần của các số
                for (int j = i - 2; j >= 0; j--)
                {
                    Console.Write((i + j) % 10);
                }

                // chuyển sang dòng tiếp theo
                Console.WriteLine();
            }
        }
    }
}
