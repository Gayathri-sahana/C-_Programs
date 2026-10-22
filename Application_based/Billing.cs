public class Billing
{
    public static void Run()
    {
        Console.Write("Enter the bill amount: ");
        double bill = Convert.ToDouble(Console.ReadLine());

        double discount;
        double gst;
        double finalAmount;

        if (bill >= 5000)
        {
            discount = bill * 0.18;
            double afterDiscount = bill - discount;

            gst = afterDiscount * 0.12;
            finalAmount = afterDiscount + gst;

            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("GST: " + gst);
            Console.WriteLine("Final Bill Amount: " + finalAmount);
        }
        else
        {
            discount = 0;
            gst = bill * 0.12;
            finalAmount = bill + gst;

            Console.WriteLine("No discount");
            Console.WriteLine("GST: " + gst);
            Console.WriteLine("Final Bill Amount: " + finalAmount);
        }
    }
}
