public class Trigno_Calcu
{
    public static void Run()
    {
        Console.Write("Enter angle in degrees: ");
        double a = Convert.ToDouble(Console.ReadLine());

        double rad = a * Math.PI / 180;

        Console.WriteLine("Sin = " + Math.Sin(rad));
        Console.WriteLine("Cos = " + Math.Cos(rad));
        Console.WriteLine("Tan = " + Math.Tan(rad));
    }
}