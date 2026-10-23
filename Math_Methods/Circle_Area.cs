public class Circle_Area
{
    public static void Run()
    {
        Random r = new Random();

        double radius = r.Next(1, 11);
        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("Radius = " + radius);
        Console.WriteLine("Area = " + Math.Round(area, 2));
    }
}