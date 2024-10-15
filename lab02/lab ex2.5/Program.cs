namespace lab_ex2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  a
            Console.WriteLine(" a:");
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                
                Console.WriteLine();
            }

            // b
            Console.WriteLine("\n b:");
            for (int i = 7; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("$");
                Console.WriteLine();
            }

            //  c
            Console.WriteLine("\n c:");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
