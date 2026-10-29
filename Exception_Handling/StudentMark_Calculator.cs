public class StudentMarkCalculator
{
    public static void Run()
    {
        try
        {
            int total = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter mark for subject " + i + ": ");
                int mark = Convert.ToInt32(Console.ReadLine());

                if (mark < 0 || mark > 100)
                    throw new ArgumentOutOfRangeException("Mark must be between 0 and 100.");

                total += mark;
            }

            double average = total / 5.0;

            Console.WriteLine("Total: " + total);
            Console.WriteLine("Average: " + average);

            if (average >= 35)
                Console.WriteLine("Result: Pass");
            else
                Console.WriteLine("Result: Fail");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric marks only.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid mark. Marks must be between 0 and 100.");
        }
        finally
        {
            Console.WriteLine("Student mark calculation process has ended.");
        }
    }
}