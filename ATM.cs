public class ATM
{
    public static void Run()
    {
        Console.WriteLine("----------------ATM----------------");
        Console.Write("Please Enter Your ATM Pin : ");
        int pin = Convert.ToInt32(Console.ReadLine());
        int crpin = 2006;
        int balance = 10000;
        if (pin == crpin)
        {
            Console.Write("Please Enter Your Amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("\nYour Transaction is Successful");
                Console.WriteLine("Please Collect Your Cash");
                balance -= amount;
                Console.WriteLine("\nEnter '1' to check your balance or '2' to exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Your Balance is : " + balance);
                    Console.WriteLine("\nThank You for using our ATM");
                }
                else
                {
                    Console.WriteLine("\nThank You for using our ATM");
                }
            }
            else
            {
                Console.WriteLine("Your Transaction is Unsuccessful");
                Console.WriteLine("Entered Amount is Greater than Your Balance");
                Console.WriteLine("\nEnter '1' to check your balance or '2' to exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("\nYour Balance is : " + balance);
                    Console.WriteLine("\nThank You for using our ATM");
                }
                else
                {
                    Console.WriteLine("\nThank You for using our ATM");
                }
            }
        }
        else
        {
            Console.WriteLine("\nInvalid Pin");
            Console.WriteLine("Please Try Again");
        }
    }
}
