namespace lab3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tao doi tuong contact voi constructor khong tham so
            Contact ct1 = new Contact();
            //gan gia tri cho ct1
            ct1.Id = 6;
            ct1.FirstName = "Nguyen Thi";
            ct1.LastName = "Hoa";
            ct1.Address = "Ha Noi";
            ct1.Phone = "0978735992";
            ct1.Email = "hoahoa@gmail.com";
            //tao doi tuong contact voi constructor co tham so
            Contact ct2 = new Contact(5,"Tran Thi","Tinh","Tuyen Quang","0987874555","bupbecotinhyeu@yahoo.com");
            //hien thi thong tin ct1 va vct2
            ct1.Display();
            ct2.Display();
        }
    }
}
