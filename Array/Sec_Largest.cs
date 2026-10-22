public class Sec_Largest
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
        int second = int.MinValue;

        for (int i = 1; i < size; i++)
        {
            if (arr[i] > largest)
            {
                second = largest;
                largest = arr[i];
            }
            else if (arr[i] > second && arr[i] < largest)
            {
                second = arr[i];
            }
        }

        if (second == int.MinValue)
        {
            Console.WriteLine("Second largest element does not exist.");
        }
        else
        {
            Console.WriteLine("Second largest element: " + second);
        }
    }
}
