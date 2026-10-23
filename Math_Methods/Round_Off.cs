public class Round_Off
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        double n = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Rounded value = " + Math.Round(n));
    }
}