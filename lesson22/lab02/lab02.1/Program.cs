namespace lab02._1
{
    /// <summary>
    /// chương trình tính tiền điện
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int number;
            double money = 0;
            //nhap thong tin
            Console.Write("nhap ten thue bao:");
            name= Console.ReadLine();
            Console.Write("Nhap so dien su dung:");
            number = Convert.ToInt32(Console.ReadLine());
            //tinh toan so tien
            if (number <= 30)
                money = 30;
            else if (number > 30 && number <=50)
                money= 30+20*1.2+(number-50) *1.5;
            //in thong tin
            Console.WriteLine("\n thong tin tien dien");
            Console.WriteLine("Ho va ten:{0}",name);
            Console.WriteLine("so dien su dung:{0}",number);
            Console.WriteLine("so tien:{0:C}",money);
        }
    }
}
