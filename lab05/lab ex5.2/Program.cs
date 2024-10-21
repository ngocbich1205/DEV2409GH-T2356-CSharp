namespace lab_ex5._2
{
    /// <summary>
    /// 1.khai báo và khởi tạo một mảng 2 chiều với 4 dòng và 4 cột
    /// 2.in mảng theo hàng cột
    /// 3. tính tổng các phần tử mà có chỉ số hàng= chỉ số cột
    /// 4. in ra các phần tử nhỏ nhất trên cột
    /// 5. liệt kê các phần tử chia hết cho 7
    /// 6.tìm tổng các phần tử nằm trên đường viền của mảng
    /// 7. chuyển thành mảng 1 chiều rồi sắp xếp tăng dần
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // 1. Khai báo và khởi tạo mảng 2 chiều với 4 dòng và 4 cột
            int[,] matrix = {
            { 8, 14, 7, 10 },
            { 21, 6, 9, 3 },
            { 5, 12, 16, 11 },
            { 2, 4, 13, 15 }
            };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            // 2. In mảng theo hàng cột
            Console.WriteLine("Mảng theo hàng cột:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // 3. Tính tổng các phần tử mà có chỉ số hàng = chỉ số cột
            int sumDiagonal = 0;
            for (int i = 0; i < rows; i++)
            {
                sumDiagonal += matrix[i, i];
            }
            Console.WriteLine($"\nTổng các phần tử mà có chỉ số hàng = chỉ số cột: {sumDiagonal}");

            // 4. In ra các phần tử nhỏ nhất trên cột
            Console.WriteLine("\nCác phần tử nhỏ nhất trên cột:");
            for (int j = 0; j < cols; j++)
            {
                int minInCol = matrix[0, j];
                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] < minInCol)
                    {
                        minInCol = matrix[i, j];
                    }
                }
                Console.WriteLine($"Cột {j + 1}: {minInCol}");
            }

            // 5. Liệt kê các phần tử chia hết cho 7
            Console.WriteLine("\nCác phần tử chia hết cho 7:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 7 == 0)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                }
            }
            Console.WriteLine();

            // 6. Tìm tổng các phần tử nằm trên đường viền của mảng
            int sumBorder = 0;
            // Cộng các phần tử trên dòng đầu và dòng cuối
            for (int j = 0; j < cols; j++)
            {
                sumBorder += matrix[0, j] + matrix[rows - 1, j];
            }
            // Cộng các phần tử bên trái và bên phải, trừ đi các góc đã cộng trước đó
            for (int i = 1; i < rows - 1; i++)
            {
                sumBorder += matrix[i, 0] + matrix[i, cols - 1];
            }
            Console.WriteLine($"\nTổng các phần tử trên đường viền: {sumBorder}");

            // 7. Chuyển mảng 2 chiều thành mảng 1 chiều rồi sắp xếp tăng dần
            int[] flatArray = new int[rows * cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flatArray[index++] = matrix[i, j];
                }
            }
            Array.Sort(flatArray);
            Console.WriteLine("\nMảng 1 chiều sau khi sắp xếp tăng dần:");
            Console.WriteLine(string.Join(", ", flatArray));
        }
    }
    
}
