public class Quadrant
{
    public static void Run()
    {
        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("First Quadrant");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Second Quadrant");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Third Quadrant");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Fourth Quadrant");
        }
        else
        {
            Console.WriteLine("Point lies on an axis or at origin");
        }
    }
}