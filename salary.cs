public class Salary
{
    public static void Run()
    {
        int totsal = 100000;
        Console.Write("Enter the number of worked days: ");

        int worked = Convert.ToInt32(Console.ReadLine());
        int totdays = 26;

        Console.Write("Enter your experience in years: ");
        int exp = Convert.ToInt32(Console.ReadLine());
        int worksal = worked * (totsal / totdays);

        if (exp >= 5)
        {
            Console.WriteLine("You got a 10% bonus...");
            double bonussal = worksal + (totsal * 0.1);
            Console.WriteLine("Your total salary with bonus is: " + bonussal);
        }
        else
        {
            Console.WriteLine("Sorry, you are not eligible for bonus...");
            Console.WriteLine("Your total salary is: " + worksal);
        }
    }
}