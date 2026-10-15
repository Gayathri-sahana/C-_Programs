public class HarshadNumber
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int temp = n, sum = 0, rem;

        while (temp > 0)
        {
            rem = temp % 10;
            sum = sum + rem;
            temp = temp / 10;
        }

        if (sum > 0 && n % sum == 0)
            Console.WriteLine("Harshad Number");
        else
            Console.WriteLine("Not Harshad Number");
    }
}