using System;

namespace immutableID
{
    class Student
    {
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }

        // Parameterized constructor with ID ONLY
        public Student(int id)
        {
            Id = id;
            FirstName = "";
            LastName = "";
        }

        // Parameterized constructor with all properties
        public Student(int id, string first, string last)
        {
            Id = id;
            FirstName = first;
            LastName = last;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // making student object
            Student student1 = new Student(1);
            student1.FirstName = "Colin";
            student1.LastName = "Elliott";

            // making second student obj
            Student student2 = new Student(2, "Christopher", "Bell");

            // display
            Console.WriteLine("Student 1 info below");
            PrintStudentInfo(student1);
            Console.WriteLine("");
            Console.WriteLine("Student 2 info below");
            PrintStudentInfo(student2);
            Console.WriteLine("");
        }

        static void PrintStudentInfo(Student student)
        {
            Console.WriteLine($"ID: {student.Id}");
            Console.WriteLine($"First Name: {student.FirstName}");
            Console.WriteLine($"Last Name: {student.LastName}");
        }
    }
}