class salary
{
    public void CalculateSalary(double basicSalary)
    {
        Console.WriteLine("Total Salary: " + basicSalary);
    }

    public void CalculateSalary(double basicSalary, double allowance)
    {
        Console.WriteLine("Total Salary: " + (basicSalary + allowance));
    }

    public void CalculateSalary(double basicSalary, double allowance, double bonus)
    {
        Console.WriteLine("Total Salary: " + (basicSalary + allowance + bonus));
    }
}

class SalaryCalculator
{
    public static void Run()
    {
        salary s = new salary();

        s.CalculateSalary(20000);
        s.CalculateSalary(20000, 5000);
        s.CalculateSalary(20000, 5000, 3000);
    }
}