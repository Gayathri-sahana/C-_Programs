
using System;

class College
{
    public string collegeName = "ABC College";

    public void ShowCollegeDetails()
    {
        Console.WriteLine("College Name: " + collegeName);
    }
}

class Staff : College
{
    public string name = "";
    public int age;
    public string department = "";

    public void GetStaffDetails()
    {
        Console.Write("Enter Staff Name: ");
        name = Console.ReadLine() ?? "";

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Department: ");
        department = Console.ReadLine() ?? "";
    }

    public void DisplayStaffDetails()
    {
        ShowCollegeDetails();
        Console.WriteLine("Staff Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Department: " + department);
    }
}

class Studenttt : College
{
    public string name = "";
    public int age;
    public int rollNo;
    public string course = "";

    public void GetStudentDetails()
    {
        Console.Write("Enter Student Name: ");
        name = Console.ReadLine() ?? "";

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Roll No: ");
        rollNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Course: ");
        course = Console.ReadLine() ?? "";
    }

    public void DisplayStudentDetails()
    {
        ShowCollegeDetails();
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Course: " + course);
    }
}
class CollegeManagementSystem
{
    public static void Run()
    {
        Console.WriteLine("College Management System");
        Console.WriteLine("1. Staff");
        Console.WriteLine("2. Student");
        Console.Write("Are you Staff or Student? Enter 1 or 2: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Staff s = new Staff();
            s.GetStaffDetails();

            Console.WriteLine("\n--- Staff Details ---");
            s.DisplayStaffDetails();
        }
        else if (choice == 2)
        {
            Studenttt s = new Studenttt();
            s.GetStudentDetails();

            Console.WriteLine("\n--- Student Details ---");
            s.DisplayStudentDetails();
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }
}
