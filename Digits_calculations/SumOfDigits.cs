public class SumOfDigits
{
    public static void Run()
    {
        Console.Write("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine("Sum of digits: " + sum);
    }
}