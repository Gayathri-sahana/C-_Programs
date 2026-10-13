
public class Pattern_Alpla
{
    public static void Run()
    {
        for (int i = 1; i <= 4; i++)
        {
            char a = 'a';
            for (int j = 1; j <= i; j++)
            {
                Console.Write(a);
                a++;
            }
            Console.WriteLine();
        }
    }
}
