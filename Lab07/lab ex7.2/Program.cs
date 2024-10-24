namespace lab_ex7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                object value = "Đây là một chuỗi";
                int so = (int)value; // Sẽ gây ra ngoại lệ InvalidCastException
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Đã bắt được ngoại lệ InvalidCastException: {ex.Message}");
            }

            // Ví dụ IndexOutOfRangeException (Ngoại lệ vượt quá chỉ số mảng)
            try
            {
                int[] numbers = { 1, 2, 3 };
                int value = numbers[10]; // Sẽ gây ra ngoại lệ IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Đã bắt được ngoại lệ IndexOutOfRangeException: {ex.Message}");
            }

            // Ví dụ ArrayTypeMismatchException (Ngoại lệ không khớp kiểu mảng)
            try
            {
                object[] objects = new object[3];
                objects[0] = "hello";
                objects[1] = 123;
                int number = (int)objects[0];// Sẽ gây ra ngoại lệ ArrayTypeMismatchException
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine($"Đã bắt được ngoại lệ ArrayTypeMismatchException: {ex.Message}");
            }
        }
    }
}
