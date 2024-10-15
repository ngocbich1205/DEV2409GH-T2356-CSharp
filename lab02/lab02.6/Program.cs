namespace lab02._6
{
    /// <summary>
    /// su dung foeach in ra danh sach cac phan tu cua mang
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Thang", "Long", "Hoa", "Dao" };
            Console.Write("Danh sach sinh vien:\n");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}
