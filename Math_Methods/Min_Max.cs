public class MinMax
{
    public static void Run()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Maximum = " + Math.Max(a, b));
        Console.WriteLine("Minimum = " + Math.Min(a, b));
    }
}