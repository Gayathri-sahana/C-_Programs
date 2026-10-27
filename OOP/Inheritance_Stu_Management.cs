class Person
{
    public string name="";
    public int age;
    public int rollNo;

    public void GetPersonDetails()
    {
        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Roll No: ");
        rollNo = Convert.ToInt32(Console.ReadLine());
    }

    public string ShowStudentDetails(string n, int a, int r)
    {
        return "Name: " + n +
               "\nAge: " + a +
               "\nRoll No: " + r;
    }
}

class Studentt : Person
{
    public int mark1, mark2, mark3;

    public void GetMarks()
    {
        Console.Write("Enter Mark 1: ");
        mark1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Mark 2: ");
        mark2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Mark 3: ");
        mark3 = Convert.ToInt32(Console.ReadLine());
    }
}

class Result : Studentt
{
    public int CalculateTotal(int m1, int m2, int m3)
    {
        return m1 + m2 + m3;
    }

    public double CalculateAverage(int total)
    {
        return total / 3.0;
    }

    public string DisplayGrade(double average)
    {
        if (average >= 90)
            return "A";
        else if (average >= 75)
            return "B";
        else if (average >= 50)
            return "C";
        else
            return "F";
    }
}

class StudentManagementSystem
{
    public static void Run()
    {
        Result s1 = new Result();

        Console.WriteLine("Enter Student Details");
        s1.GetPersonDetails();
        s1.GetMarks();

        int total = s1.CalculateTotal(
            s1.mark1, s1.mark2, s1.mark3);

        double average = s1.CalculateAverage(total);
        string grade = s1.DisplayGrade(average);

        Console.WriteLine("\n--- Student Report ---");

        Console.WriteLine(s1.ShowStudentDetails(
            s1.name, s1.age, s1.rollNo));

        Console.WriteLine("Mark 1: " + s1.mark1);
        Console.WriteLine("Mark 2: " + s1.mark2);
        Console.WriteLine("Mark 3: " + s1.mark3);
        Console.WriteLine("Total: " + total);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Grade: " + grade);
    }
}

