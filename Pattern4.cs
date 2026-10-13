public class Pattern4
{
    public static void Run()
    {
        int n = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(n + " ");
                n++;
            }
            Console.WriteLine();
        }
    }
}
