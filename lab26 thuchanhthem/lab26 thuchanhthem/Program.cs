namespace lab26_thuchanhthem
{
    /// <summary>
    /// Tạo ứng dụng thực hiện các công việc sau
    /// - Khởi tạo một mảng 1 chiều gồm 10 phần tử Student.
    /// - Tìm phần tử student có tuổi nhỏ nhất của mảng.
    /// - Sắp xếp mảng tăng dần theo tuổi sinh viên (student).
    /// - Tìm sinh viên có tuổi lớn nhất.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Student[] students = new Student[10]
            {
            new Student(1, "Bích", 21),
            new Student(2, "An", 19),
            new Student(3, "Cường", 22),
            new Student(4, "Dũng", 21),
            new Student(5, "Lan", 23),
            new Student(6, "Giang", 18),
            new Student(7, "Hà", 24),
            new Student(8, "Khang", 22),
            new Student(9, "Linh", 20),
            new Student(10, "Mai", 19)
            };
            int chon = 0;
            do
            {
                menu();
                Console.Write("Mời bạn chọn:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        // 1. Tìm phần tử Student có tuổi nhỏ nhất
                        Student youngestStudent = students.OrderBy(s => s.Age).First();
                        Console.WriteLine($"Sinh viên có tuổi nhỏ nhất: {youngestStudent}");
                        break;
                    case 2:
                        // 2. Sắp xếp mảng tăng dần theo tuổi sinh viên
                        Student[] sortedStudents = students.OrderBy(s => s.Age).ToArray();
                        Console.WriteLine("\nMảng sau khi sắp xếp theo tuổi tăng dần:");
                        foreach (var student in sortedStudents)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    case 3:
                        // 3. Tìm sinh viên có tuổi lớn nhất
                        Student oldestStudent = students.OrderByDescending(s => s.Age).First();
                        Console.WriteLine($"\nSinh viên có tuổi lớn nhất: {oldestStudent}");
                        break;
                    case 4:
                        Console.WriteLine("kết thúc");
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai mời chọn lại");
                        break;
                }
            } while (chon !=4);          
        }
        static void menu()
        {
            Console.WriteLine("----------MENU----------\n" +
                "1.Tìm phần tử student có tuổi nhỏ nhất của mảng.\n" +
                "2.Sắp xếp mảng tăng dần theo tuổi sinh viên (student).\n" +
                "3.Tìm sinh viên có tuổi lớn nhất.");
        }
    }
}
