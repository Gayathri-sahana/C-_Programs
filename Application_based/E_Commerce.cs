
public class E_Commerce
{
    public static void Run()
    {
        Console.WriteLine("1. Watch - 5000");
        Console.WriteLine("2. Stationary - 3000");
        Console.WriteLine("3. Dress - 8000");

        Console.Write("Enter product choice: ");
        int p = Convert.ToInt32(Console.ReadLine());

        int price = 0;
        string coupon = "";

        switch (p)
        {
            case 1:
                price = 5000;
                coupon = "wat001";
                break;
            case 2:
                price = 3000;
                coupon = "sat002";
                break;
            case 3:
                price = 8000;
                coupon = "dre003";
                break;
            default:
                Console.WriteLine("Invalid product");
                return;
        }

        Console.Write("Enter quantity: ");
        int q = Convert.ToInt32(Console.ReadLine());

        int total = price * q;

        Console.WriteLine("Order Value = " + total);

        Console.Write("Enter coupon code: ");
        string c = Console.ReadLine();

        if (q >= 5 && c == coupon)
        {
            total = total - (total * 15 / 100);
            Console.WriteLine("15% Discount Applied");
        }
        else
        {
            Console.WriteLine("Coupon Not Applicable");
        }

        Console.Write("Enter payment method (Gpay/PhonePe): ");
        string pay = Console.ReadLine();

        if (pay == "Gpay" || pay == "PhonePe")
        {
            total = total + 350;
            Console.WriteLine("Shipping Charges = 350");
            Console.WriteLine("Payment Method = " + pay);
            Console.WriteLine("Final Amount = " + total);
        }
        else
        {
            Console.WriteLine("Invalid Payment Method");
        }
    }
}
