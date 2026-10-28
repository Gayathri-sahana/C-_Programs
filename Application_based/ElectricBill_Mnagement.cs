public class ElectricityBill
{
    public static void Run()
    {
        int customers;
        double totalRevenue = 0;

        Console.Write("Enter number of customers: ");
        customers = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= customers; i++)
        {
            Console.Write("Enter Customer ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Units Consumed: ");
            int units = Convert.ToInt32(Console.ReadLine());

            double energyCharge;

            if (units <= 100)
                energyCharge = units * 2;
            else if (units <= 200)
                energyCharge = 100 * 2 + (units - 100) * 3;
            else
                energyCharge = 100 * 2 + 100 * 3 + (units - 200) * 5;

            double fixedCharge = 50;
            double surcharge = 0;

            if (energyCharge > 500)
                surcharge = energyCharge * 0.05;

            double bill = energyCharge + fixedCharge + surcharge;
            totalRevenue += bill;

            Console.WriteLine("\n--- Electricity Bill ---");
            Console.WriteLine("Customer ID: " + id);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Units: " + units);
            Console.WriteLine("Energy Charge: Rs. " + energyCharge);
            Console.WriteLine("Fixed Charge: Rs. " + fixedCharge);
            Console.WriteLine("Surcharge: Rs. " + surcharge);
            Console.WriteLine("Total Bill: Rs. " + bill);

            if (bill <= 250)
                Console.WriteLine("Category: Low Usage");
            else if (bill <= 750)
                Console.WriteLine("Category: Medium Usage");
            else
                Console.WriteLine("Category: High Usage");
        }

        Console.WriteLine("\nTotal Customers: " + customers);
        Console.WriteLine("Total Revenue: Rs. " + totalRevenue);
    }
}