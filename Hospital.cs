
public class Hospital
{
    public static void Run()
    {
        Console.WriteLine("1. General Ward - 500");
        Console.WriteLine("2. Private Room - 2000");
        Console.WriteLine("3. ICU - 5000");

        Console.Write("Enter room choice: ");
        int r = Convert.ToInt32(Console.ReadLine());

        int room = 0;

        switch (r)
        {
            case 1:
                room = 500;
                break;
            case 2:
                room = 2000;
                break;
            case 3:
                room = 5000;
                break;
            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        Console.Write("Enter number of days: ");
        int d = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        int c = 800;
        int total = (room * d) + c;

        Console.WriteLine("Room Charges = " + (room * d));
        Console.WriteLine("Consultation Charges = " + c);

        if (age >= 60)
        {
            int dis = total * 5 / 100;
            total = total - dis;
            Console.WriteLine("Senior Citizen Discount = " + dis);
        }

        Console.WriteLine("Insurance = Not Applicable");
        Console.WriteLine("Medicine and Lab Charges = Not Applicable");
        Console.WriteLine("Final Amount = " + total);
    }
}
