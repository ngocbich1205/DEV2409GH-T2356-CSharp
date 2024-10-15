namespace labex2._8
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            // nhap so tien gui, lai suat, so thang
            Console.Write("nhap vao so tien gui (VND): ");
            double sotiengui = double.Parse(Console.ReadLine());

            Console.Write("nhap lai suat hang nam (%): ");
            double laisuatnam = double.Parse(Console.ReadLine());

            Console.Write("nhap so thang: ");
            int sothanggui = int.Parse(Console.ReadLine());

            // tinh lai suat hang thang
            double laisuathangthang = (laisuatnam / 12) / 100;


            double sodu = sotiengui;
            Console.WriteLine("Thang\t sodu\t lai");
            for (int thang = 1; thang <= sothanggui; thang++)
            {
                // Calculate interest for the current month
                double lai = sodu * laisuathangthang;
                sodu += lai;

                // Print interest and balance for the current month
                Console.WriteLine($"thang {thang}:\t{sodu:N2} \t{lai:N2}");
            }
            double tonglai = sodu - sotiengui;
            Console.WriteLine($"tong lai sau{sothanggui} thang:{tonglai:N2}");
        }

    }
}
