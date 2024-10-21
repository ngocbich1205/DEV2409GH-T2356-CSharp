namespace lab05
{
    /// <summary>
    /// Một số thao tác với mảng 1 chiều
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai báo và khởi tạo mảng 1 chiều
            int[] m = { 5, 8, 3, 0, 2, 1, 7, 8 };
            //duyệt mảng và in dữ liệu
            Console.Write("Cac phan tu cua mang:");
            for (int i = 0; i < m.Length; i++) {
                Console.Write("{0}", m[i]);
            }
            //tim phan tu lon nhat
            int max = m[0];
            for (int i = 0; i < m.Length; i++)
            {
                if (max < m[i])
                    max = m[i];
            }
            Console.WriteLine("\nPhan tu lon nhat:" + max);
            //kiem tra mang co doi xung khong
            bool kt = true;
            for (int i = 0; i < m.Length / 2; i++)
            {
                if (m[i] != m[m.Length - 1 - i])
                {
                    kt = false;
                    break;
                }
            }
            if (kt)

                Console.WriteLine("Mang doi xung");
            else
                Console.WriteLine("Mang khong doi xung");
        }
    }
}
