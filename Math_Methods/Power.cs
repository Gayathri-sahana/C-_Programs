public class Power
{
    public static void Run()
    {
        Console.Write("Enter base: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exponent: ");
        double e = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Power = " + Math.Pow(b, e));
    }
}