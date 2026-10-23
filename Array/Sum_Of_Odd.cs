public class Sum_Of_Odd
{
    public static void Run()
    {
        int[] numbers = { 2, 3, 1, 3, 9, 10 };
        int oddSum = 0;

        for (int num=0;num<numbers.Length;num++)
        {
            if (num % 2 != 0)
            {
                oddSum += num;
            }
        }

        Console.WriteLine("Total Odd Numbers Sum: "+oddSum);
    }
}