public class CountDigits
{
    public static void Run()
    {
        Console.Write("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (n > 0)
        {
            count++;
            n /= 10;
        }
        Console.WriteLine("Number of digits: " + count);
    }
}
     