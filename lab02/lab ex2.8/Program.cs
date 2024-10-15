namespace lab_ex2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nhap so tien gui, lai suat, so thang
            Console.Write("nhap vao so tien gui (VND): ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());

            Console.Write("nhap lai suat hang nam (%): ");
            decimal annualInterestRate = decimal.Parse(Console.ReadLine());

            Console.Write("nhap so thang: ");
            int months = int.Parse(Console.ReadLine());

            // tinh lai suat hang thang
            decimal monthlyInterestRate = (annualInterestRate / 12) / 100;

            
            decimal finalBalance = depositAmount;
            for (int i = 1; i <= months; i++)
            {
                decimal interestEarned = finalBalance * monthlyInterestRate;
                finalBalance += interestEarned;
            }

            // in ra ket qua
            Console.WriteLine("\n--- ket qua ---");
            Console.WriteLine($"lai suat hang thang: {monthlyInterestRate * 100}%");
            Console.WriteLine($"so du cuoi cung sau {months} thang: {finalBalance} VND");
        }
    }
    
}
