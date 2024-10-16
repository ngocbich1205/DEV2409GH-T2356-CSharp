namespace lab03
{
    /// <summary>
    /// minh họa việc khởi tạo đối tượng, truy cập các truòng và phuogw thức
    /// </summary>
    internal class Program
    {
       static void Main(string[] args)
        {
            //tao doi tuong Car
            Car myCar = new Car();
            //gan gia tri cho cac truong cua doi tuong
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.year = 1995;
            //hien thi thong tin ve doi tuong myCar
            System.Console.WriteLine("thong tin chi tiet:");
            System.Console.WriteLine("Make:" + myCar.make);
            System.Console.WriteLine("Model:" +myCar.model);
            System.Console.WriteLine("Color:" +myCar.color);
            System.Console.WriteLine("Year release:" +myCar.year);
            //goi cac phuong thuc
            myCar.Start();
            myCar.Stop();
        }
    }
}
