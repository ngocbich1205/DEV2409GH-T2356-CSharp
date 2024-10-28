using System.Collections;

namespace lab30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chon;
            do
            {
                Console.WriteLine("Option:");
                Console.WriteLine("===============================");
                Console.WriteLine("1. Insert new student...");
                Console.WriteLine("2. Display all the student list...");
                Console.WriteLine("3. Calculator average mark...");
                Console.WriteLine("4. Exit.");
                Console.WriteLine("Choose an option");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        InsertNewStudent();
                        break;
                    case 2:
                        PrintAllStudents();
                        break;
                    case 3:
                        CalculateAndPrintAverages();
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            } while (chon != 4);
        }
        static Hashtable studentTable= new Hashtable();
        static void InsertNewStudent()
        {
            Student student = new Student();
            Console.WriteLine("Input student ID: ");
            student.StudID= int.Parse(Console.ReadLine());
            Console.WriteLine("Input student name: ");
            student.StudName = Console.ReadLine();
            Console.WriteLine("Input student gender: ");
            student.StudGender = Console.ReadLine();
            Console.WriteLine("Input student age: ");
            student.StudAge= int.Parse(Console.ReadLine());
            Console.WriteLine("Input student class:");
            student.StudClass = Console.ReadLine();
            for (int i = 0;i<3; i++)
            {
                Console.Write($"input mark {i + 1}:");
                student[i] = int.Parse(Console.ReadLine());
            }
            student.CalAvg();
            studentTable[student.StudID]= student;
            Console.WriteLine("Student added successfully\n");
        }
        static void PrintAllStudents()
        {
            foreach (Student student in studentTable.Values)
            {
                student.Print();
                Console.WriteLine("--------------");
            }
        }
        static void CalculateAndPrintAverages()
        {
            foreach (Student student in studentTable.Values)
            {
                student.Print();
                student.CalAvg();
                Console.WriteLine("---------------");
            }
        }
    }
}
