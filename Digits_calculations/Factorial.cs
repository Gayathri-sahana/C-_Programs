public class Factorial
{
    public static void Run()
    {
        Console.WriteLine("Enter number to calculate factorial: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        Console.WriteLine("Factorial of " + n + " is: " + fact);
    }
}