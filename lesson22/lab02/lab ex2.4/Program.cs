namespace lab_ex2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("so co ba chu so co tng la so chan la:");

            for (int i = 100; i <= 999; i++)
            {
                int sum = (i / 100) + ((i / 10) % 10) + (i % 10);

                if (sum % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
