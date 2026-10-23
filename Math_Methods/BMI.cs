public class BMI
{
    public static void Run()
    {
        Console.Write("Enter weight in kg: ");
        double w = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height in metres: ");
        double h = Convert.ToDouble(Console.ReadLine());

        double bmi = w / Math.Pow(h, 2);

        Console.WriteLine("BMI = " + bmi);
    }
}