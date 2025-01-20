using System;
using System.Collections.Generic;

namespace Sms
{
    class StudentManagemenSystem
    {
        // Student class
        class Student
        {
            public string firstName { get; set; }
            public string middleName { get; set; }
            public string lastName { get; set; }
            public string studentId { get; set; }
            public string contacts { get; set; }

            // Student class constructor
            public Student(string firstName, string middleName, string lastName, string studentId, string contacts)
            {
                this.firstName = firstName;
                this.middleName = middleName;
                this.lastName = lastName;
                this.studentId = studentId;
                this.contacts = contacts;
            }
        }
        class ManageStudent
        {
            public List<Student> students = new List<Student>();

            

            public void AddStudent()
            {
                Console.WriteLine("Enter Student first name:");
                string firstName = Console.ReadLine()!;
                Console.WriteLine("Enter Student middle name:");
                string middleName = Console.ReadLine()!;
                Console.WriteLine("Enter Student last name:");
                string lastName = Console.ReadLine()!;
                Console.WriteLine("Enter Student ID:");
                string studentId = Console.ReadLine()!;
                Console.WriteLine("Enter Student contacts:");
                string contacts = Console.ReadLine()!;

                students.Add(new Student(firstName, middleName, lastName, studentId, contacts));
            }
            public void DisplayStudentInfo()
            {
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine($"  | SurName     | First name    | Last Name    | student Id   | Student Contact ");
                Console.WriteLine("----------------------------------------------------------------------------------");
                foreach (var student in students)
                {
            
                    Console.WriteLine($"  | {student.lastName}        | {student.firstName}           | {student.middleName}          |{student.studentId}          |{student.contacts}");
                }
                Console.WriteLine("----------------------------------------------------------------------------------");
            }

            public void DeleteStudent()
            {
                Console.WriteLine("Enter Student ID to delete:");
                string studentId = Console.ReadLine()!;

            }
        }
        static void Main(string[] args)
        {
            ManageStudent manageStudent = new ManageStudent();
            // manageStudent.AddStudent();
            //manageStudent.DisplayStudentInfo();
            //manageStudent.DeleteStudent();
            while (true)
            {
                Console.WriteLine("SELECT ONE CHOICE:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Student Information");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Exit");
                int choice = int.Parse(Console.ReadLine()!);

                switch(choice)
                {
                    case 1:
                    manageStudent.AddStudent();
                    break;
                    case 2:
                    manageStudent.DisplayStudentInfo();
                    break;
                    case 3:
                    manageStudent.DeleteStudent();
                    break;
                    case 4:
                     Console.WriteLine("Exiting the program...");
                        Environment.Exit(0); // Terminates the program completely
                        break;
                    default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
                }
            }

        }
    }

}