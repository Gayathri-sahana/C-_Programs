public class Abs_Value
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Absolute value = " + Math.Abs(n));
    }
}