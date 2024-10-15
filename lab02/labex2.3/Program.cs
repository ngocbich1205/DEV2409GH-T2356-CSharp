namespace labex2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap vao so nguyen duong la so giay : ");
            int totalSeconds = int.Parse(Console.ReadLine());

            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            Console.WriteLine($"{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
