public class Frequency_of_digits
{
    public static void Run()
    {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            int found = 0;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] == arr[j])
                {
                    found = 1;
                }
            }
            if (found == 0)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(arr[i] + " -> " + count);
            }
        }
    }
}
