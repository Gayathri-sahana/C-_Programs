public class PatternG
{
    public static void Run()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                if ((i == 1 && j > 1) ||
                    (i == 4 && j > 1) ||
                    (j == 1 && i > 1 && i < 4) ||
                    (j == 4 && i >= 3) ||
                    (i == 3 && j >= 3))
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}