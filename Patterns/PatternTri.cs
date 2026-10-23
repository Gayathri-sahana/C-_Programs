
public class PatternTri
{
    public static void Run()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(2 * j + " ");
            }
            Console.WriteLine();
        }
    }
}
