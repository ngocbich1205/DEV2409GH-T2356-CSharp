
namespace lab02._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 != 0) { 
                    sum+= i;
                }
            }
            Console.WriteLine("tong cac so chan khong chia het cho 3 tu 1-100 la {0}",sum);
        }
    }
}
