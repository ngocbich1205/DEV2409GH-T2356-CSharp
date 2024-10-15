namespace lab_ex2._6
{
    /// <summary>
    /// kiểm tra xem 3 canh có phai là một tam giác
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("nhap canh a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("nhap canh b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("nhap canh c: ");
            int c = int.Parse(Console.ReadLine());

            if (IsValidTriangle(a, b, c))
            {
                Console.WriteLine("a,b,c là 3 cạnh của một tam giác");
                DetermineTriangleType(a, b, c);
            }
            else
            {
                Console.WriteLine("a,b,c không phải 3 cạnh của tam giác");
            }
        }

        static bool IsValidTriangle(int a, int b, int c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        static void DetermineTriangleType(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Đay là tam giác đều");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Đây là tam giác cân ");
            }
            else
            {
                Console.WriteLine("Đây là tam giác thường");
            }
        }
    }

}

