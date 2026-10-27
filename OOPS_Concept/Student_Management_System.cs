class Student
{
    string name;
    int rollNo, age;
    int mark1, mark2, mark3;

    void GetStudentDetails()
    {
        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Roll No: ");
        rollNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Mark 1: ");
        mark1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Mark 2: ");
        mark2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Mark 3: ");
        mark3 = Convert.ToInt32(Console.ReadLine());
    }

    string ShowStudentDetails(string n, int r, int a)
    {
        return "Name: " + n +
               "\nRoll No: " + r +
               "\nAge: " + a;
    }

    int CalculateTotal(int m1, int m2, int m3)
    {
        return m1 + m2 + m3;
    }

    double CalculateAverage(int total)
    {
        return total / 3.0;
    }

    string DisplayGrade(double avg)
    {
        if (avg >= 90)
            return "A";
        else if (avg >= 75)
            return "B";
        else if (avg >= 50)
            return "C";
        else
            return "F";
    }

    public static void Run()
    {
        for (int i = 1; i <= 2; i++)
        {
            Student s = new Student();

            Console.WriteLine("\nEnter Details for Student " + i);
            s.GetStudentDetails();

            int total = s.CalculateTotal(
                s.mark1, s.mark2, s.mark3);

            double average = s.CalculateAverage(total);
            string grade = s.DisplayGrade(average);

            Console.WriteLine("\n--- Student " + i + " Details ---");
            Console.WriteLine(s.ShowStudentDetails(
                s.name, s.rollNo, s.age));

            Console.WriteLine("Mark 1: " + s.mark1);
            Console.WriteLine("Mark 2: " + s.mark2);
            Console.WriteLine("Mark 3: " + s.mark3);
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Grade: " + grade);
        }
    }
}
