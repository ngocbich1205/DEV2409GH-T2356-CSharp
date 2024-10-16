namespace lab_ex3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo một số đối tượng Employee
            Employee emp1 = new Employee(1, "Tran Ngoc Bich", 2003, 2.5, 5000);
            Employee emp2 = new Employee(2, "Le Thi B", 1995, 3.0, 6000);

            emp1.Display();
            emp2.Display();
        }
    }
}
