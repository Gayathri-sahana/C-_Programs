using System;

class Recharge
{
    public string CustomerName;
    public string MobileNumber;
    public double PlanPrice;
    public double Balance;

    public Recharge(string name, string number, double balance)
    {
        CustomerName = name;
        MobileNumber = number;
        Balance = balance;
    }
    public virtual void GetPlanDetails()
    {
        Console.WriteLine("Recharge Plan");
    }
    public void RechargeAmount()
    {
        if (Balance >= PlanPrice)
        {
            Balance = Balance - PlanPrice;
            Console.WriteLine("Recharge Successful");
            Console.WriteLine("Remaining Balance: "+ Balance);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
}

class BasicPlan : Recharge
{
    public BasicPlan(string name, string number, double balance) : base(name, number, balance)
    {
        PlanPrice = 199;
    }

    public override void GetPlanDetails()
    {
        Console.WriteLine("Customer: " + CustomerName);
        Console.WriteLine("Plan: Basic");
        Console.WriteLine("Validity: 28 Days");
        Console.WriteLine("Daily Data: 1 GB");
        Console.WriteLine("Total Data: " + (28 * 1) + " GB");
        Console.WriteLine("Plan Price: " + PlanPrice);
        RechargeAmount();
    }
}
class PremiumPlan : Recharge
{
    public PremiumPlan(string name, string number, double balance) : base(name, number, balance)
    {
        PlanPrice = 399;
    }

    public override void GetPlanDetails()
    {
        Console.WriteLine("Customer: " + CustomerName);
        Console.WriteLine("Plan: Premium");
        Console.WriteLine("Validity: 56 Days");
        Console.WriteLine("Daily Data: 2 GB");
        Console.WriteLine("Total Data: " + (56 * 2) + " GB");
        Console.WriteLine("Plan Price: " + PlanPrice);
        RechargeAmount();
    }
}
class UnlimitedPlan : Recharge
{
    public UnlimitedPlan(string name, string number, double balance) : base(name, number, balance)
    {
        PlanPrice = 599;
    }

    public override void GetPlanDetails()
    {
        Console.WriteLine("Customer: " + CustomerName);
        Console.WriteLine("Plan: Unlimited");
        Console.WriteLine("Validity: 84 Days");
        Console.WriteLine("Daily Data: 3 GB");
        Console.WriteLine("Total Data: " + (84 * 3) + " GB");
        Console.WriteLine("Plan Price: " + PlanPrice);
        RechargeAmount();
    }
}

class MobileRechargeManagement
{
    public static void Run()
    {
        Recharge obj = new PremiumPlan("Sahana", "9876543210", 1000);
        obj.GetPlanDetails();
    }
}