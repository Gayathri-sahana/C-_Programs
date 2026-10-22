public class Largest
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

        int largest = arr[0];

        for (int i = 1; i < size; i++)
        {
            if (arr[i] > largest)
            {
                largest = arr[i];
            }
        }

        Console.WriteLine("Largest element: " + largest);
    }
}