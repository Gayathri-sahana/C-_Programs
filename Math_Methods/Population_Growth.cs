public class Population_Growth
{
    public static void Run()
    {
        Console.Write("Enter initial population: ");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter growth rate (decimal): ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter years: ");
        int y = Convert.ToInt32(Console.ReadLine());

        double result = p * Math.Exp(r * y);

        Console.WriteLine("Final population = " + result);
    }
}