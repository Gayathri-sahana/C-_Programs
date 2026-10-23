public class Odd
{
    public static void Run()
    {
        Console.WriteLine("Odd numbers from 1 - 100 are: ");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}
