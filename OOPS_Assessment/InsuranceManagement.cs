using System;

abstract class Insurance
{
    public string PolicyHolder;
    public double PolicyAmount;
    public int PolicyDuration;

    public Insurance(string name, double amount, int duration)
    {
        PolicyHolder = name;
        PolicyAmount = amount;
        PolicyDuration = duration;
    }

    public abstract double CalculatePremium();

    public void DisplayPolicyDetails(string type)
    {
        if (PolicyAmount <= 0 || PolicyDuration <= 0)
        {
            Console.WriteLine("Invalid Policy Details");
        }
        else
        {
            double annual = CalculatePremium();

            Console.WriteLine("Policy Type: " + type);
            Console.WriteLine("Policy Holder: " + PolicyHolder);
            Console.WriteLine("Policy Amount: " + PolicyAmount);
            Console.WriteLine("Annual Premium: " + annual);
            Console.WriteLine("Duration: " + PolicyDuration + " Years");
            Console.WriteLine("Total Premium: " + (annual * PolicyDuration));
        }
    }
}

class LifeInsurance : Insurance
{
    public LifeInsurance(string name, double amount, int duration) : base(name, amount, duration)
    {
    }

    public override double CalculatePremium()
    {
        return PolicyAmount * 0.02;
    }
}

class HealthInsurance : Insurance
{
    public HealthInsurance(string name, double amount, int duration) : base(name, amount, duration)
    {
    }

    public override double CalculatePremium()
    {
        return PolicyAmount * 0.03;
    }
}

class VehicleInsurance : Insurance
{
    public VehicleInsurance(string name, double amount, int duration) : base(name, amount, duration)
    {
    }

    public override double CalculatePremium()
    {
        return PolicyAmount * 0.05;
    }
}

class InsuranceManagement
{
    static void Main()
    {
        Insurance obj = new LifeInsurance("Sahana", 1000000, 5);

        obj.DisplayPolicyDetails("Life Insurance");
    }
}