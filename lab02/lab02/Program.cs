namespace lab02
{
    /// <summary>
    /// chương trình minh họa việc nhập xuất trong ứng dụng console
    /// Nhập vào mã sinh viên, tên sinh viên, ngày sinh và điểm 3 môn
    /// In ra thông tin sinh viên và điểm trung bình
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string id, name;
            double mark1, mark2, mark3, average;
            DateTime birthday;
            //nhap du lieu tu ban phim
            Console.Write("nhap ma so:");
            id= Console.ReadLine();
            Console.Write("Nhap ten:");
            name= Console.ReadLine();
            Console.Write("nhap ngay sinh:");
            birthday=Convert.ToDateTime(Console.ReadLine());
            Console.Write("nhap diem mon 1:");
            mark1= Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap diem mon 2:");
            mark2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap diem mon 3:");
            mark3 = Convert.ToDouble(Console.ReadLine());
            //tính điểm trung bình
            average = (mark1 + mark2 + mark3) / 3;
            // in thông tin ra màn hình
            Console.WriteLine("\n Thong tin sinh vien");
            Console.WriteLine("Ma so:{0}", id);
            Console.WriteLine("Ho va ten:{0}", name);
            Console.WriteLine("Ngày sinh: {0:dd/MM/yyyy}", birthday);

            Console.WriteLine(" Diem 1: {0:N}, Diem 2:{1:N}, Diem 2:{2:N}", mark1, mark2, mark3);

            Console.WriteLine("Diem trung binh: {0:N}", average);
        }
    }
}
