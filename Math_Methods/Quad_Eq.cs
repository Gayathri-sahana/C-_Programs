public class Quad_Eq
{
    public static void Run()
    {
        Console.Write("Enter a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double d = b * b - 4 * a * c;

        if (a == 0)
            Console.WriteLine("Not a quadratic equation.");
        else if (d >= 0)
        {
            double r1 = (-b + Math.Sqrt(d)) / (2 * a);
            double r2 = (-b - Math.Sqrt(d)) / (2 * a);

            Console.WriteLine("Root 1 = " + r1);
            Console.WriteLine("Root 2 = " + r2);
        }
        else
            Console.WriteLine("Roots are imaginary.");
    }
}