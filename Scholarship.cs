
public class Scholarship
{
    public static void Run()
    {
        Console.Write("Enter your percentage: ");
        int m = Convert.ToInt32(Console.ReadLine());

        if (m > 90)
        {
            Console.WriteLine("50% Scholarship");
        }
        else
        {
            Console.WriteLine("Not Eligible");
        }
    }
}
