
public class VehicleRental
{
    public static void Run()
    {
        Console.WriteLine("1. Car - 1000/day");
        Console.WriteLine("2. Bike - 300/day");

        Console.Write("Enter vehicle choice: ");
        int v = Convert.ToInt32(Console.ReadLine());

        int price = 0;

        switch (v)
        {
            case 1:
                price = 1000;
                break;
            case 2:
                price = 300;
                break;
            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Do you have a driving licence (Yes/No): ");
        string l = Console.ReadLine();

        if (age > 20 && age <= 45 && l == "Yes")
        {
            Console.Write("Enter rental days: ");
            int d = Convert.ToInt32(Console.ReadLine());

            int total = price * d;

            Console.WriteLine("Rental Amount = " + total);
        }
        else
        {
            Console.WriteLine("Not Eligible for Rental");
        }
    }
}