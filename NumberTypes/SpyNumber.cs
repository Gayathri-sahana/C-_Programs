public class SpyNumber
{
    public static void Run()
    {
        Console.Write("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int temp = n, sum = 0, prod = 1, rem;

        while (temp > 0)
        {
            rem = temp % 10;
            sum = sum + rem;
            prod = prod * rem;
            temp = temp / 10;
        }
        if (sum == prod)
            Console.WriteLine("Spy Number");
        else
            Console.WriteLine("Not Spy Number");
    }
}
