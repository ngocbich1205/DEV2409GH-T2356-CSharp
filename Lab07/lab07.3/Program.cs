﻿namespace lab07._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai bao mang
            byte[] a = new byte[5];
            //nhap mang
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.Write("a[{0}]=", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Khong duoc nhap ky tu cho mang so");
            }
            catch (OverflowException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Khong duoc nhap gia tri nam ngoai mien 0-255");
            }
            catch (IndexOutOfRangeException ex)
            {
                //Console.WriteLine(ex.Message)
                Console.WriteLine("Loi vuot qua pham vi cua mang");
            }
            //in mang
            Console.WriteLine("Noi dung mang");
            for (int i = 0; i < 5; i++)
                Console.Write(" {0}", a[i]);
        }
    }
}