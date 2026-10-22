public class Even
{
    public static void Run()
    {
        Console.WriteLine("Even numbers from 1 to 50 are: ");
        for (int i = 1 ; i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}
