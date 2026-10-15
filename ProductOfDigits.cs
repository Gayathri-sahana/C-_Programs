public class ProductOfDigits
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int product = 1;
        while (n > 0)
        {
            product *= n % 10;
            n /= 10;
        }
        Console.WriteLine("Product of digits: " + product);
    }
}