// Lab Project: Student Management System

// Project Overview:

// You will create a basic Student Management System using the concepts learned in
// Classes 1 to 4. The system will allow users to add, view, search, and remove students
// from a collection. Each student will have attributes such as Name, Age, Grade, and ID.
// The project will utilize arrays, loops, OOP principles, string manipulation, and
// collections (without using LINQ).

// Project Requirements:

// 1. Create a Student Class:
// o Properties:
// ▪ int ID
// ▪ string Name
// ▪ int Age
// ▪ double Grade

// o Methods:
// ▪ DisplayDetails(): Prints the details of the student.
// ▪ IsPassing(): Returns true if the student's grade is 60 or above,
// otherwise returns false.

// 2. Student Array:
// o Create an array to store up to 50 Student objects.

// 3. Menu System:
// o Implement a menu-driven console application that provides the following
// options:

// a. Add a New Student: Prompt the user to enter the student's details (ID, Name,
// Age, Grade) and add the student to the array.
// b. View All Students: Display the details of all students in the array, including
// whether they are passing or failing.
// c. Search for a Student by ID: Allow the user to search for a student by their ID and
// display their details if found.
// d. Remove a Student by ID: Allow the user to remove a student from the array by
// their ID.
// e. Update a Student's Grade: Allow the user to update the grade of an existing
// student by their ID.
// f. Exit: Close the application.

// 4. Validation and Error Handling:
// o Ensure that the user cannot enter invalid data (e.g., negative grades, nonnumeric IDs).
// o Handle cases where the array is full and cannot accept more students.
// o Provide appropriate messages when searching for or removing a student
// that does not exist.

// 5. String Manipulation:
// o Ensure the Name property is always stored in title case (e.g., "john doe"
// should be stored as "John Doe").
// o Implement a method CapitalizeWords() that converts any input string to
// title case and use it before storing the Name.

// 6. Sorting Students:
// o Add a feature that allows the user to sort the students by their grades in
// descending order and display the sorted list.

// 7. Statistics:
// o Add a feature that calculates and displays the average grade of all
// students.
// o Add a feature that counts and displays the number of students who are
// passing.

// Implementation Steps:
// 1. Define the Student Class:
// o Create a class with the required properties and methods.
// o Implement the DisplayDetails(), IsPassing(), and CapitalizeWords()
// methods.

// 2. Initialize the Array:
// o Create an array to hold Student objects, with a capacity of 50.

// 3. Build the Menu System:
// o Implement a loop that displays the menu options and processes user
// input.
// o Use switch statements or if-else conditions to handle the different menu
// options.

// 4. Add Validation and Error Handling:
// o Ensure that the program handles invalid inputs and provides user-friendly
// error messages.

// 5. Implement Sorting and Statistics:
// o Write the logic to sort the students by grade and calculate the required
// statistics.

// 6. Test the Application:
// o Test the program with various inputs to ensure that all features work as
// expected.

using System;

namespace StudentManagementSystem
{
    class Student
    {
        private int id;
        public int ID
        {
            get { return id; }
            set
            {
                // Validate if the input is a valid integer
                if (value >= 0) // Assuming ID should be a non-negative integer
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("Invalid ID. ID should be a non-negative integer.");
                }
            }
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Student(int id, string name, int age, double grade)
        {
            ID = id;
            Name = CapitalizeWords(name);
            Age = age;
            Grade = grade;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}, Grade: {Grade} - {(IsPassing() ? "Passing" : "Failing")}");
        }

        public bool IsPassing()
        {
            return Grade >= 60;
        }

        private string CapitalizeWords(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var words = input.ToLower().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
            }
            return string.Join(' ', words);
        }
    }

    class Program
    {
        static Student[] students = new Student[50];
        static int studentCount = 0;

        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.WriteLine("\nWelcome to the Student Management System");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1. Add a New Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Search for a Student by ID");
                Console.WriteLine("4. Remove a Student by ID");
                Console.WriteLine("5. Update a Student's Grade");
                Console.WriteLine("6. Sort Students by Grade");
                Console.WriteLine("7. Display Average Grade");
                Console.WriteLine("8. Count Passing Students");
                Console.WriteLine("9. Exit");
                Console.Write("Enter your choice: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewAllStudents();
                        break;
                    case 3:
                        SearchStudentByID();
                        break;
                    case 4:
                        RemoveStudentByID();
                        break;
                    case 5:
                        UpdateStudentGrade();
                        break;
                    case 6:
                        SortStudentsByGrade();
                        break;
                    case 7:
                        DisplayAverageGrade();
                        break;
                    case 8:
                        CountPassingStudents();
                        break;
                }
            } while (option != 9);

            Console.WriteLine("Goodbye!");
        }

        static void AddStudent()
        {
            if (studentCount >= students.Length)
            {
                Console.WriteLine("Student array is full. Cannot add more students.");
                return;
            }

            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Grade: ");
            double grade = double.Parse(Console.ReadLine());

            students[studentCount] = new Student(id, name, age, grade);
            studentCount++;
            Console.WriteLine("Student added successfully!");
        }

        static void ViewAllStudents()
        {
            Console.WriteLine("Student List:");
            for (int i = 0; i < studentCount; i++)
            {
                students[i].DisplayDetails();
            }
        }

        static void SearchStudentByID()
        {
            Console.Write("Enter Student ID to search: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].ID == id)
                {
                    students[i].DisplayDetails();
                    return;
                }
            }

            Console.WriteLine("Student not found.");
        }

        static void RemoveStudentByID()
        {
            Console.Write("Enter Student ID to remove: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].ID == id)
                {
                    for (int j = i; j < studentCount - 1; j++)
                    {
                        students[j] = students[j + 1];
                    }
                    students[--studentCount] = null;
                    Console.WriteLine("Student removed successfully.");
                    return;
                }
            }

            Console.WriteLine("Student not found.");
        }

        static void UpdateStudentGrade()
        {
            Console.Write("Enter Student ID to update grade: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].ID == id)
                {
                    Console.Write("Enter new grade: ");
                    students[i].Grade = double.Parse(Console.ReadLine());
                    Console.WriteLine("Grade updated successfully.");
                    return;
                }
            }

            Console.WriteLine("Student not found.");
        }

        static void SortStudentsByGrade()
        {
            Array.Sort(students, 0, studentCount, Comparer<Student>.Create((x, y) => y.Grade.CompareTo(x.Grade)));
            Console.WriteLine("Students sorted by grade:");
            ViewAllStudents();
        }

        static void DisplayAverageGrade()
        {
            if (studentCount == 0)
            {
                Console.WriteLine("No students to calculate the average grade.");
                return;
            }

            double total = 0;
            for (int i = 0; i < studentCount; i++)
            {
                total += students[i].Grade;
            }
            double average = total / studentCount;
            Console.WriteLine($"Average Grade: {average}");
        }

        static void CountPassingStudents()
        {
            int count = 0;
            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].IsPassing())
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of Passing Students: {count}");
        }
    }
}

// Enter your choice: 1
// Enter Student ID: 111
// Enter Student Name: ALI
// Enter Student Age: 18
// Enter Student Grade: 59
// Student added successfully!

// Enter your choice: 2
// Student List:
// ID: 111, Name: Ali, Age: 18, Grade: 59 - Failing
// ID: 112, Name: Abu, Age: 19, Grade: 65 - Passing
// ID: 113, Name: Amat, Age: 20, Grade: 70 - Passing
// ID: 124, Name: Lim, Age: 21, Grade: 90 - Passing
// ID: 125, Name: Muthu, Age: 24, Grade: 95 - Passing

// Enter your choice: 3
// Enter Student ID to search: 112
// ID: 112, Name: Abu, Age: 19, Grade: 34 - Failing

// Enter your choice: 5
// Enter Student ID to update grade: 112
// Enter new grade: 34
// Grade updated successfully.

// Enter your choice: 2
// Student List:
// ID: 111, Name: Ali, Age: 18, Grade: 59 - Failing
// ID: 112, Name: Abu, Age: 19, Grade: 34 - Failing
// ID: 113, Name: Amat, Age: 20, Grade: 70 - Passing
// ID: 124, Name: Lim, Age: 21, Grade: 90 - Passing
// ID: 125, Name: Muthu, Age: 24, Grade: 95 - Passing

// Enter your choice: 6
// Students sorted by grade:
// Student List:
// ID: 125, Name: Muthu, Age: 24, Grade: 95 - Passing
// ID: 124, Name: Lim, Age: 21, Grade: 90 - Passing
// ID: 113, Name: Amat, Age: 20, Grade: 70 - Passing
// ID: 111, Name: Ali, Age: 18, Grade: 59 - Failing
// ID: 112, Name: Abu, Age: 19, Grade: 34 - Failing

// Enter your choice: 7
// Average Grade: 69.6

// Enter your choice: 8
// Number of Passing Students: 3

// Enter your choice: 4
// Enter Student ID to remove: 124
// Student removed successfully.

// Enter your choice: 2
// Student List:
// ID: 125, Name: Muthu, Age: 24, Grade: 95 - Passing
// ID: 113, Name: Amat, Age: 20, Grade: 70 - Passing
// ID: 111, Name: Ali, Age: 18, Grade: 59 - Failing
// ID: 112, Name: Abu, Age: 19, Grade: 34 - Failing

// Welcome to the Student Management System
// -------------------------------------------
// 1. Add a New Student
// 2. View All Students
// 3. Search for a Student by ID
// 4. Remove a Student by ID
// 5. Update a Student's Grade
// 6. Sort Students by Grade
// 7. Display Average Grade
// 8. Count Passing Students
// 9. Exit
// Enter your choice: 9
// Goodbye!