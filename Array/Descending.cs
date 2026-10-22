public class Descending
{
    public static void Run()
    {
        Console.WriteLine("Enter array size:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        
        Console.WriteLine("Descending order:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
