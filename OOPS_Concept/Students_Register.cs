class student
{
    string name = "Gayathri";
    int rollNo = 101;
    int mark1 = 85, mark2 = 90, mark3 = 80;
    int total;
    double average;

    void ShowStudentDetails()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Roll Number: " + rollNo);
        Console.WriteLine("Mark 1: " + mark1);
        Console.WriteLine("Mark 2: " + mark2);
        Console.WriteLine("Mark 3: " + mark3);
    }

    void CalculateTotal()
    {
        total = mark1 + mark2 + mark3;
        Console.WriteLine("Total Marks: " + total);
    }

    void CalculateAverage()
    {
        average = total / 3.0;
        Console.WriteLine("Average: " + average);
    }

    void DisplayGrade()
    {
        if (average >= 90)
            Console.WriteLine("Grade: A");
        else if (average >= 75)
            Console.WriteLine("Grade: B");
        else if (average >= 50)
            Console.WriteLine("Grade: C");
        else
            Console.WriteLine("Grade: F");
    }

    public static void Run()
    {
        student s = new student();

        s.ShowStudentDetails();
        s.CalculateTotal();
        s.CalculateAverage();
        s.DisplayGrade();
    }
}