public class Pattern7_Inverse
{
    public static void Run()
    {
        int n = 4;

        for (int i = n; i >= 1; i--)
        {
            for (int s = 1; s <= n - i; s++)
            {
                Console.Write("  ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }
}