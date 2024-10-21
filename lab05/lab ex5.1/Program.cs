using System.ComponentModel.Design;

namespace lab_ex5._1
{
    /// <summary>
    /// Tạo ứng dụng C# và thực hiện những công việc sau.
    /// - Khởi tạo một mảng 1 chiều số nguyên gồm 10 phần tử.
    /// - Tìm phần tử nhỏ nhất của mảng.
    /// - Đảo ngược mảng.
    /// - Sắp xếp mảng tăng hoặc giảm.
    /// - Tìm phần tử là số nguyên tố.
    /// - In ra số lượng các số dương liên tiếp nhiều nhất.
    /// - Tính trung bình cộng các phần tử dương.
    /// - Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không?.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khởi tạo mảng 1 chiều với 10 phần tử ngẫu nhiên
            int[] array = { 3, 8, -2, 7, 12, 5, -9, 10, 4, 6 };
            int chon = 0;
            do
            {
                menu();
                Console.Write("Mời bạn chọn:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        // 1. Tìm phần tử nhỏ nhất của mảng
                        int min = array.Min();
                        Console.WriteLine($"Phần tử nhỏ nhất: {min}");
                        break;
                    case 2:
                        // 2. Đảo ngược mảng
                        Array.Reverse(array);
                        Console.WriteLine("Mảng sau khi đảo ngược: " + string.Join(", ", array));
                        break;
                    case 3:
                        // 3. Sắp xếp mảng tăng dần hoặc giảm dần
                       
                        
                            Console.WriteLine("Mảng trước khi sắp:{0}", String.Join("  ", array));
                            Array.Sort(array);
                            Console.WriteLine("Sorted:{0}", String.Join("  ", array));
                        
                        break;
                    case 4:
                        //4. Tìm phần tử là số nguyên tố
                        Console.Write("Các số nguyên tố trong mảng: ");
                        foreach (var num in array)
                        {
                            if (IsPrime(num))
                            {
                                Console.Write(num + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        // 5. in ra số lượng các số dương liên tiếp nhiều nhất 
                        int count = 0;
                        for (int i = 0; i < array.Length - 1; i++)
                        {
                            if (array[i] % 2 == 0 && array[i + 1] % 2 == 0)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine($"Số lượng các số dương liên tiếp nhiều nhất: {count}");
                        break;
                    case 6:
                        // 6. Tính trung bình cộng các số dương
                        var positive = array.Where(x => x > 0);
                        double Positive = positive.Any() ? positive.Average() : 0;
                        Console.WriteLine($"Trung bình cộng các số dương: {Positive}");
                        break;
                    case 7:
                        // 7. Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không
                        bool isAlternating = true;
                        for (int i = 0; i < array.Length - 1; i++)
                        {
                            if ((array[i] > 0 && array[i + 1] > 0) || (array[i] < 0 && array[i + 1] < 0))
                            {
                                isAlternating = false;
                                break;
                            }
                        }
                        Console.WriteLine($" mảng có phải chứa các phần tử âm dương, đan xen nhau không: {isAlternating}");
                        break;
                    case 8:
                        Console.WriteLine("kết thúc");
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng mời chọn lại");
                        break;
                }
            } while (chon != 8);
        }
            //menu chức năng
            static void menu(){
                Console.WriteLine("1. Tìm phần tử nhỏ nhất của mảng.\n" +
                    " 2. Đảo ngược mảng\n" +
                    "3. Sắp xếp mảng tăng dần hoặc giảm dần\n" +
                    "4. Tìm phần tử là số nguyên tố\n" +
                    "5. in ra số lượng các số dương liên tiếp nhiều nhất \n" +
                    " 6. Tính trung bình cộng các số dương\n"+
                    "7. Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không"
                    );
            }
          
        // Hàm kiểm tra số nguyên tố
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
