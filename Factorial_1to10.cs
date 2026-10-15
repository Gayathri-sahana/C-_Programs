public class Factorial_1to10
{
    public static void Run()
    {
        Console.WriteLine("\n-------------Factorial (1 to 10)-------------\n");
        for (int n = 1; n <= 10; n++)
        {
            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine(n + "! = " + fact);
        }
    }
}