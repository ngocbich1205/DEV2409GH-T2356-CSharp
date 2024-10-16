using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_ex3._1
{
    internal class Employee
    {
        // Các thuộc tính
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public double SalaryLevel { get; set; }
        public double BasicSalary { get; set; }

        // Constructor
        public Employee(int id, string name, int yearOfBirth, double salaryLevel, double basicSalary)
        {
            Id = id;
            Name = name;
            YearOfBirth = yearOfBirth;
            SalaryLevel = salaryLevel;
            BasicSalary = basicSalary;
        }

        // Phương thức tính tổng thu nhập
        public double GetIncome()
        {
            return SalaryLevel * BasicSalary;
        }

        // Phương thức hiển thị thông tin nhân viên
        public void Display()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Year of Birth: " + YearOfBirth);
            Console.WriteLine("Salary Level: " + SalaryLevel);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("Total Income: " + GetIncome());
        }
    }

   

}


