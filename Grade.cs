public class Grade
{
    public static void Run()
    {
        Console.Write("Enter your mark: ");
        int mark = Convert.ToInt32(Console.ReadLine());

        if (mark >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (mark >= 80)
        {
            Console.WriteLine("Grade B");
        }
        else if (mark >= 70)
        {
            Console.WriteLine("Grade C");
        }
        else if (mark >= 60)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}
