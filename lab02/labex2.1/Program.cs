namespace labex2._1
{
    internal class Program
    {
        struct Employee
        {
            public int Id;
            public string Name;
            public string Address;
            public DateTime Birthday;
            public decimal Salary;
            public decimal Bonus;

            public decimal TotalSalary
            {
                get { return Salary + Bonus; }
            }
        }

     
    static void Main(string[] args)
        {
            Employee emp;

            // nhap du lieu nhan vien
            Console.Write("nhap ID nhan vien: ");
            emp.Id = int.Parse(Console.ReadLine());

            Console.Write("nhap ten nhan vien: ");
            emp.Name = Console.ReadLine();

            Console.Write("nhap dia chi cua nhan vien: ");
            emp.Address = Console.ReadLine();

            Console.Write("nhap ngay thang nam sinh cua nhan vien: ");
            emp.Birthday = DateTime.Parse(Console.ReadLine());

            Console.Write("nhap luong cua nhan vien: ");
            emp.Salary = decimal.Parse(Console.ReadLine());

            Console.Write("nhap tien thuong cua nhan vien: ");
            emp.Bonus = decimal.Parse(Console.ReadLine());

            // in du lieu ra man hinh
            Console.WriteLine("\n--- thong tin nhan vien ---");
            Console.WriteLine($"ID: {emp.Id}");
            Console.WriteLine($"Name: {emp.Name}");
            Console.WriteLine($"Address: {emp.Address}");
            Console.WriteLine($"Birthday: {emp.Birthday.ToShortDateString()}");
            Console.WriteLine($"Salary: {emp.Salary}");
            Console.WriteLine($"Bonus: {emp.Bonus}");
            Console.WriteLine($"Total Salary (Salary + Bonus): {emp.TotalSalary}");
        }

    }
}

