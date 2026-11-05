using System;
class PPerson
{
    public string Name;
    public int Age;

    public PPerson(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class SStudent : PPerson
{
    public int StudentId;
    public string CourseName;
    public double CourseFee;

    public SStudent(string name, int age, int id, string course, double fee) : base(name, age)
    {
        StudentId = id;
        CourseName = course;
        CourseFee = fee;
    }

    public double CalculateAdmissionFee()
    {
        return CourseFee + 1000;
    }

    public void DisplayStudentDetails()
    {
        base.DisplayDetails();

        Console.WriteLine("Student ID: " + StudentId);
        Console.WriteLine("Course: " + CourseName);
        Console.WriteLine("Course Fee: " + CourseFee);
        Console.WriteLine("Admission Fee: 1000");
        Console.WriteLine("Total Fee: " + CalculateAdmissionFee());
    }
}

class StudentAdmissionSystem
{
    public static void Run()
    {
        SStudent s = new SStudent("Priya", 20, 101, "Full Stack Development", 20000);
        s.DisplayStudentDetails();
    }
}