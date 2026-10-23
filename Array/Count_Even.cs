public class Count_Even
{
    public static void Run()
    {
        int[] numbers = { 9, 1, 18, 8, 5, 1 };
        int evenCount = 0;

        for (int i=0;i<numbers.Length;i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine("Total Even Numbers Count: "+evenCount);
    }
}