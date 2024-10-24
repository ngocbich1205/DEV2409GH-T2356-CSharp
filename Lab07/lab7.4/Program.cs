namespace lab7._4
{ 
    //dinh nghia lop custom ngoai le chi cho nhap so nguyen duong
    public class InvalidInputNumber: Exception
    {
        public InvalidInputNumber()
            : base("hay nhap 1 so >0") { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int intCnt;
            int intNum = 0;
            Console.Write("Nhap 1 so :");
            //nhap a tung ngoai le
            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());
                if (intNum <= 0)
                {
                    throw new InvalidInputNumber();
                }
            }
            catch (InvalidInputNumber objInvalidInput)
            {
                Console.WriteLine(objInvalidInput.Message);
            }
            catch (System.FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }
            finally
            {
                if (intNum > 0)
                {
                    //in ra day so *100
                    for (intCnt = 1; intCnt <= 10; intCnt++)
                        Console.WriteLine(intCnt * intNum);
                }
            }
            Console.ReadLine();
        }
    }
}
