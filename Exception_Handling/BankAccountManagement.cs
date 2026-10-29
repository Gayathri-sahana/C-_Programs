public class BankAccountManagement
{
    double balance = 1000;

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be greater than zero.");

        balance += amount;
        Console.WriteLine("Amount deposited successfully.");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be greater than zero.");

        if (amount > balance)
            throw new InvalidOperationException("Insufficient balance.");

        balance -= amount;
        Console.WriteLine("Amount withdrawn successfully.");
    }

    public void CheckBalance()
    {
        Console.WriteLine("Current balance: " + balance);
    }

    public static void Main()
    {
        BankAccountManagement account = new BankAccountManagement();

        try
        {
            account.CheckBalance();

            Console.Write("Enter deposit amount: ");
            double deposit = Convert.ToDouble(Console.ReadLine());
            account.Deposit(deposit);

            Console.Write("Enter withdrawal amount: ");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(withdraw);

            account.CheckBalance();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numeric amount.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Bank transaction process has ended.");
        }
    }
}