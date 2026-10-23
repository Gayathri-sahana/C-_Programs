public class Prime_Array
{
    public static void Run()
    {
        int size;

        Console.WriteLine("Enter  size of the array:");
        size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        Console.WriteLine("Enter the array elements:");

        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Prime numbers in the array:");

        for (int i = 0; i < size; i++)
        {
            int count = 0;

            if (arr[i] > 1)
            {
                for (int j = 1; j <= arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
