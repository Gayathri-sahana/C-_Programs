public class ArmstrongNumber
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int temp = n, sum = 0, rem, count = 0;

        while (temp > 0)
        {
            count++;
            temp = temp / 10;
        }
        temp = n;

        while (temp > 0)
        {
            rem = temp % 10;
            int p = 1;
            for (int i = 1; i <= count; i++)
                p = p * rem;
            
            sum = sum + p;
            temp = temp / 10;
        }

        if (sum == n)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not Armstrong Number");
    }
}
