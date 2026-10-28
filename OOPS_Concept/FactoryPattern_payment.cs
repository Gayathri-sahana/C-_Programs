public interface IPayment
{
    void Pay();
}

public class GPay : IPayment
{
    public void Pay() => Console.WriteLine("Payment through GPay");
}

public class CreditCard : IPayment
{
    public void Pay() => Console.WriteLine("Payment through Credit Card");
}

public class Cash : IPayment
{
    public void Pay() => Console.WriteLine("Payment through Cash");
}

public class PaymentFactory
{
    public static IPayment GetPayment(string paymentType)
    {
        if (paymentType == "GPay")
            return new GPay();
        else if (paymentType == "CreditCard")
            return new CreditCard();
        else if (paymentType == "Cash")
            return new Cash();
        else
            return null;
    }
}

public class PaymentProgram
{
    public static void Run()
    {
        IPayment payment1 = PaymentFactory.GetPayment("GPay");
        payment1.Pay();

        IPayment payment2 = PaymentFactory.GetPayment("CreditCard");
        payment2.Pay();

        IPayment payment3 = PaymentFactory.GetPayment("Cash");
        payment3.Pay();
    }
}
