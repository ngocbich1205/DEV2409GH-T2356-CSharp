namespace lab1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            String name ;
            DateTime birth;
            String address;
            String phone;
            String email;
            id = 1;
            name = "Tran Ngoc Bich";
            birth = DateTime.Now;
            address = "Hai Phong";
            phone = "0389664503";
            email = "ngocbich@gmail.com";
            Console.WriteLine("Ma nhan vien:"+ id);
            Console.WriteLine("Ten nhan vien:"+ name);
            Console.WriteLine("Ngay sinh:" + birth);
            Console.WriteLine("Dia chi:" + address);
            Console.WriteLine("Dien thoai:" + phone);
            Console.WriteLine("email:" + email);
        }
    }
}
