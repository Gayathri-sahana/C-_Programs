public class HotelBooking
{
    public static void Run()
    {
        Console.WriteLine("--------------- HOTEL ROOM BOOKING SYSTEM ---------------");

        // Room type
        Console.WriteLine("Select Room Type:");
        Console.WriteLine("1. Standard - Rs.1000 per day\n2. Deluxe   - Rs.2000 per day\n3. Suite    - Rs.3000 per day");
        Console.Write("Enter your choice (1,2,3): ");

        if (!int.TryParse(Console.ReadLine(), out int choice) ||
            choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid room type!");
            return;
        }

        double roomRate;

        if (choice == 1)
        {
            roomRate = 1000;
        }
        else if (choice == 2)
        {
            roomRate = 2000;
        }
        else
        {
            roomRate = 3000;
        }

        Console.Write("Enter number of days: ");

        if (!int.TryParse(Console.ReadLine(), out int days) || days <= 0)
        {
            Console.WriteLine("Invalid number of days!");
            return;
        }

        Console.WriteLine("Customer Type:");
        Console.WriteLine("1. Membership");
        Console.WriteLine("2. Normal");
        Console.Write("Enter your choice: ");

        if (!int.TryParse(Console.ReadLine(), out int customerType) ||
            (customerType != 1 && customerType != 2))
        {
            Console.WriteLine("Invalid customer type!");
            return;
        }

        Console.Write("Do you want food? (yes/no): ");
        string food = Console.ReadLine() ?? "";

        if (!food.Equals("yes", StringComparison.OrdinalIgnoreCase) &&
            !food.Equals("no", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Invalid food choice!");
            return;
        }

        double roomCharge = roomRate * days;
        double foodCharge = food.Equals(
            "yes", StringComparison.OrdinalIgnoreCase)
            ? 500 * days : 0;

        double subtotal = roomCharge + foodCharge;

        double discount = customerType == 1
            ? roomCharge * 0.05 : 0;

        double taxableAmount = subtotal - discount;
        double gst = taxableAmount * 0.12;
        double finalBill = taxableAmount + gst;

        Console.WriteLine("\n------------------ FINAL BILL ------------------");
        Console.WriteLine("\nRoom Rate: Rs." + roomRate);
        Console.WriteLine("Number of Days: " + days);
        Console.WriteLine("Room Charges: Rs." + roomCharge);
        Console.WriteLine("Food Charges: Rs." + foodCharge);
        Console.WriteLine("Discount: Rs." + discount);
        Console.WriteLine("GST (12%): Rs." + gst);
        Console.WriteLine("\nFinal Bill: Rs." + finalBill);
        Console.WriteLine("\n---------- THANK YOU FOR BOOKING WITH US! ----------");
    }
}
