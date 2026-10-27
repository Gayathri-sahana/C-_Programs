class DeliveryCharge
{
    public void CalculateDeliveryCharge(double distance)
    {
        Console.WriteLine("Delivery Charge: " + (distance * 10));
    }

    public void CalculateDeliveryCharge(double distance, double weight)
    {
        Console.WriteLine("Delivery Charge: " + (distance * 10 + weight * 5));
    }

    public void CalculateDeliveryCharge(double distance, double weight, bool isExpress)
    {
        double charge = distance * 10 + weight * 5;

        if (isExpress)
        {
            charge += 100;
        }

        Console.WriteLine("Delivery Charge: " + charge);
    }
}

class DeliveryChargeCalculator
{
    public static void Run()
    {
        DeliveryCharge d = new DeliveryCharge();

        d.CalculateDeliveryCharge(10);
        d.CalculateDeliveryCharge(10, 5);
        d.CalculateDeliveryCharge(10, 5, true);
    }
}
