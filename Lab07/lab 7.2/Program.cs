﻿namespace lab_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //tạo mới đối tượng House trong namespace Business
           //bạn có thể using ở trên đầu tệp tin để viết ngắn gọn hơn
           Business.House h= new Business.House();
            //gán thông tin
            h.HouseNo = "D294FF";
            h.Price = 425880;
            // in thông tin
            Console.WriteLine("House detail");
            Console.WriteLine("\t House No:" +h.HouseNo);
            Console.WriteLine("\t Price:" + h.Price); 
            //tạo mới đối tượng car trong namespace Business.Dealership
            //bạn có thể using ở trên đầu tệp tin để viết ngắn gọn hơn
            Business.Dealership.Car c = new Business.Dealership.Car();
            c.CarNo = "A0999";
            c.Price = 38425.50M;
            //in thong tin
            Console.WriteLine("Car detail");
            Console.WriteLine("\t Car No:" + h.HouseNo);
            Console.WriteLine("\t Price" +h.Price);

        }
    }
}
