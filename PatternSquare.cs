public class PatternSquare
{
    public static void Run()
    {
        Console.WriteLine("Square Pattern of (4 x 4) :");
        for (int i = 1; i <= 4 ; i++)
        {
            for (int j =1 ; j<=4 ; j ++)
            {
                Console.Write ( j + " ");
            }
            Console.WriteLine();
        }
    }
}

