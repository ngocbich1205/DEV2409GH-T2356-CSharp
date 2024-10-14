namespace lab02._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check_i;
            Console.Write("danh sach cac so nguyen to t 2-100:");
            //duyet tu 2-100
            for (int i = 2; i <= 100; i++)
            {
                check_i = true;// gia su i la so nguyen to
                for (int j=2;j<=i/2; j++)// duyet tu 2-j/2
                {
                    if (i%j == 0)//neu i chia het cho j thi
                    {
                        check_i=false;//ket luan khong la so nguyen to
                        break;
                    }
                }
                if(check_i)// neu gia su van dung->i la so nguyen to
                Console.Write("{0}",i);
            }
        }
    }
}
