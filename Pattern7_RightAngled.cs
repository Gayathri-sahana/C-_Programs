
public class Pattern7_RightAngled

{
    public static void Run()
    {
        int n = 4;

        for (int i = 1; i <= n; i++)
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
