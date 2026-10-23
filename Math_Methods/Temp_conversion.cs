public class Temp_conversion
{
    public static void Run()
    {
        Console.Write("Enter Celsius: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double f = Math.Round((c * 9 / 5) + 32, 2);

        Console.WriteLine("Fahrenheit = " + f);
    }
}