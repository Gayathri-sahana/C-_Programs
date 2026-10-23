public class Compound_interest
{
    public static void Run()
    {
        Console.Write("Enter principal: ");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time in years: ");
        int t = Convert.ToInt32(Console.ReadLine());

        double ci = p * Math.Pow(1 + r / 100, t) - p;

        Console.WriteLine("Compound Interest = " + ci);
    }
}