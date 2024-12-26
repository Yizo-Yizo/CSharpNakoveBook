using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class TestStudent
    {
        private static List<Student> students;
        public static List<Student> Students
        {
            get { return students; }
        }

        public void TestingStudent()
        {
            // Test case 1: Create a student with full information
            Student student1 = new Student("John Doe", "Computer Science", "Programming", "XYZ University", "john.doe@xyz.edu", "123-456-7890");
            student1.PrintStudentInfo();

            // Test case 2: Create a student with only name and course
            Student student2 = new Student("Jane Smith", "Mathematics");
            Console.WriteLine("Student 2 Information:");
            student2.PrintStudentInfo();
            Console.WriteLine();

            // Test case 3: Create a student with only name
            Student student3 = new Student("Alice Brown");
            Console.WriteLine("Student 3 Information:");
            student3.PrintStudentInfo();
            Console.WriteLine();

            // Test case 4: Display the total number of created Student objects
            Console.WriteLine("Total number of students created: {0}", Student.Count);
        }

        // Ch 14 No. 7
        public static void CreateStudents()
        {
            students = new List<Student>()
            {
                new Student("Alice", "Mathematics", "Algebra", "University A", "alice@example.com", "1234567890"),
                new Student("Bob", "Physics", "Quantum Mechanics", "University B", "bob@example.com", "0987654321"),
                new Student("Charlie", "Computer Science", "Data Structures", "University C", "charlie@example.com", "1122334455")
            };
        }
        public static void DisplayStudentsInfo()
        {
            foreach (var student in Students)
            {
                student.PrintStudentInfo();
                Console.WriteLine();  // For spacing between students
            }
        }
    }
}
